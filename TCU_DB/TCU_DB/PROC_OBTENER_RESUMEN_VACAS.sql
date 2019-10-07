CREATE PROCEDURE [dbo].[PROC_OBTENER_RESUMEN_VACAS]
AS
	BEGIN
		--Constantes
		DECLARE @CANTIDAD_MESES_DESTETE INT = 7;
		DECLARE @CANTIDAD_MESES_PARTO INT = 9;


		DECLARE @cantidad_vacas INT;
		DECLARE @resultado_resumen TIPO_RESUMEN_VACAS;
		--Se obtiene la cantidad de vacas registradas
		SELECT @cantidad_vacas = COUNT (*) FROM [dbo].[VACA];
		IF @cantidad_vacas > 0
		BEGIN
			DECLARE @indice_vacas INT = 0;
			DECLARE @numero_trazable_ultima_vaca INT = -1;
			DECLARE @temporal_nombre NVARCHAR(20);
			DECLARE @temporal_cantidad_partos INT = 0;
			DECLARE @temporal_fecha_nacimiento_vaca DATETIME;
			DECLARE @temporal_fecha_primer_parto DATETIME;
			DECLARE @temporal_edad_primer_parto INT;
			DECLARE @temporal_fecha_actual DATETIME = GETDATE();
			DECLARE @temporal_fecha_nacimiento_ultima_cria DATETIME;
			DECLARE @temporal_edad_ultima_cria INT;
			DECLARE @temporal_numero_trazable_ultima_cria INT;
			DECLARE @temporal_fecha_destete_ultima_cria DATETIME;
			DECLARE @temporal_iep_vaca DECIMAL (3,1);
			DECLARE @temporal_ultimo_iep_vaca DECIMAL (3,1);
			DECLARE @temporal_ultima_monta DATETIME;
			DECLARE @temporal_dias_gestacion INT;
			DECLARE @temporal_fecha_parto DATETIME;

			--Se obtiene la información de todas las vacas
			WHILE @indice_vacas < @cantidad_vacas
			BEGIN
				--Número trazable, nombre y fecha de nacimiento
				SELECT TOP(1) @numero_trazable_ultima_vaca = V.PK_NUMERO_TRAZABLE, @temporal_nombre = V.NOMBRE, @temporal_fecha_nacimiento_vaca = V.FECHA_NACIMIENTO FROM [dbo].[VACA] V WHERE V.PK_NUMERO_TRAZABLE > @numero_trazable_ultima_vaca ORDER BY V.PK_NUMERO_TRAZABLE ASC;
				--Cantidad de partos
				SELECT @temporal_cantidad_partos = COUNT (*) FROM [dbo].[PARTO] WHERE PK_FK_NUMERO_TRAZABLE_VACA = @numero_trazable_ultima_vaca;
				--Edad primer parto
				IF @temporal_cantidad_partos > 0 AND @temporal_fecha_nacimiento_vaca IS NOT NULL
					BEGIN
						SELECT TOP(1) @temporal_fecha_primer_parto = P.PK_FECHA FROM [dbo].[PARTO] P WHERE P.PK_FK_NUMERO_TRAZABLE_VACA = @numero_trazable_ultima_vaca ORDER BY P.PK_FECHA ASC;
						SET @temporal_edad_primer_parto = CAST(DATEDIFF(MONTH, @temporal_fecha_nacimiento_vaca, @temporal_fecha_primer_parto) AS INT);
					END
				--Edad, fecha destete y numero trazable de última cría
				IF @temporal_cantidad_partos > 0
				BEGIN
					SELECT TOP(1) @temporal_fecha_nacimiento_ultima_cria = V.FECHA_NACIMIENTO, @temporal_numero_trazable_ultima_cria = V.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] V WHERE V.ACTIVA = 1 AND V.FK_NUMERO_TRAZABLE_VACA = @numero_trazable_ultima_vaca ORDER BY V.FECHA_NACIMIENTO DESC;
					IF @temporal_fecha_nacimiento_ultima_cria IS NOT NULL
						BEGIN
							SET @temporal_edad_ultima_cria = CAST(DATEDIFF(MONTH, @temporal_fecha_nacimiento_ultima_cria, @temporal_fecha_actual) AS INT);
							IF @temporal_edad_ultima_cria < 7
							BEGIN
								SET @temporal_fecha_destete_ultima_cria = CAST(DATEADD(MONTH, @CANTIDAD_MESES_DESTETE, @temporal_fecha_nacimiento_ultima_cria) AS INT);
							END
						END
					--IEP y Ultimo IEP
					EXEC [dbo].[PROC_OBTENER_ULTIMO_IEP] @idVaca = @numero_trazable_ultima_vaca, @ultimoIEP = @temporal_ultimo_iep_vaca OUTPUT;
					EXEC [dbo].[PROC_OBTENER_IEP] @idVaca = @numero_trazable_ultima_vaca, @IEP = @temporal_iep_vaca OUTPUT;
				END

				--Fecha última monta
				SELECT TOP(1) @temporal_ultima_monta = M.PK_FECHA FROM [dbo].[FECHAS_CELOS] M WHERE M.PK_FK_NUMERO_TRAZABLE_VACA = @numero_trazable_ultima_vaca ORDER BY M.PK_FECHA DESC;

				--Dias de gestación y fecha de parto
				IF @temporal_ultima_monta IS NOT NULL AND CAST(DATEDIFF(MONTH, @temporal_ultima_monta, @temporal_fecha_actual) AS INT) <= 9
				BEGIN
						SET @temporal_dias_gestacion = CAST(DATEDIFF(DAY, @temporal_ultima_monta, @temporal_fecha_actual) AS INT);
						SET @temporal_fecha_parto = CAST(DATEADD(MONTH, @CANTIDAD_MESES_PARTO, @temporal_ultima_monta) AS INT);
				END
				
				--Se insertan los datos de la vaca en los resultados
				INSERT INTO @resultado_resumen 
				VALUES (@numero_trazable_ultima_vaca, @temporal_nombre, @temporal_edad_primer_parto, @temporal_cantidad_partos, @temporal_edad_ultima_cria, @temporal_fecha_destete_ultima_cria, @temporal_iep_vaca, @temporal_ultimo_iep_vaca, @temporal_ultima_monta, @temporal_dias_gestacion, @temporal_fecha_parto);
				
				--Se incrementa el indice
				SET @indice_vacas = @indice_vacas + 1;

				--Se limpian los datos temporales
				SET @temporal_nombre = NULL;
				SET @temporal_cantidad_partos = NULL;
				SET @temporal_fecha_nacimiento_vaca = NULL;
				SET @temporal_fecha_primer_parto = NULL;
				SET @temporal_edad_primer_parto = NULL;
				SET @temporal_fecha_nacimiento_ultima_cria = NULL;
				SET @temporal_edad_ultima_cria = NULL;
				SET @temporal_numero_trazable_ultima_cria = NULL;
				SET @temporal_fecha_destete_ultima_cria = NULL;
				SET @temporal_iep_vaca = NULL;
				SET @temporal_ultimo_iep_vaca = NULL;
				SET @temporal_ultima_monta = NULL;
				SET @temporal_dias_gestacion = NULL;
				SET @temporal_fecha_parto = NULL;
			END
		END
		--Se realiza la consulta a devolver
		SELECT * FROM @resultado_resumen
	END
