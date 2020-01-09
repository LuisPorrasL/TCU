CREATE PROCEDURE [dbo].[PROC_OBTENER_RESUMEN_VACAS]
AS
	BEGIN
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
			DECLARE @temporal_edad_primer_parto INT;
			DECLARE @temporal_edad_ultima_cria INT;
			DECLARE @temporal_fecha_destete_ultima_cria DATETIME;
			DECLARE @temporal_iep_vaca DECIMAL (8, 2);
			DECLARE @temporal_ultimo_iep_vaca DECIMAL (8, 2);
			DECLARE @temporal_ultima_monta DATETIME;
			DECLARE @temporal_dias_gestacion INT;
			DECLARE @temporal_fecha_parto DATETIME;

			--Se obtiene la información de todas las vacas
			WHILE @indice_vacas < @cantidad_vacas
			BEGIN
				--Número trazable, nombre y fecha de nacimiento
				SELECT TOP(1) @numero_trazable_ultima_vaca = V.PK_NUMERO_TRAZABLE, @temporal_nombre = V.NOMBRE FROM [dbo].[VACA] V WHERE V.PK_NUMERO_TRAZABLE > @numero_trazable_ultima_vaca ORDER BY V.PK_NUMERO_TRAZABLE ASC;
				--Cantidad de partos
				SELECT @temporal_cantidad_partos = COUNT (*) FROM [dbo].[PARTO] WHERE PK_FK_NUMERO_TRAZABLE_VACA = @numero_trazable_ultima_vaca;
				
				--Edad primer parto, edad ultima cría y fecha destete de última cría
				IF @temporal_cantidad_partos > 0
				BEGIN
					--Edad primer parto
					EXEC [dbo].[PROC_OBTENER_EDAD_PRIMER_PARTO] @numeroTrazableVaca = @numero_trazable_ultima_vaca, @edadPrimerParto = @temporal_edad_primer_parto OUTPUT;
					
					--Edad última cría
					EXEC [dbo].[PROC_OBTENER_EDAD_ULTIMA_CRIA] @numeroTrazableVaca = @numero_trazable_ultima_vaca, @edadUltimaCria = @temporal_edad_ultima_cria OUTPUT;
					
					--Fecha de destete de última cría
					EXEC [dbo].[PROC_OBTENER_FECHA_DESTETE_ULTIMA_CRIA] @numeroTrazableVacaMadre = @numero_trazable_ultima_vaca, @fechaDesteteUltimaCria = @temporal_fecha_destete_ultima_cria OUTPUT;
					
					--Último IEP
					EXEC [dbo].[PROC_OBTENER_ULTIMO_IEP] @idVaca = @numero_trazable_ultima_vaca, @ultimoIEP = @temporal_ultimo_iep_vaca OUTPUT;
					
					--IEP
					EXEC [dbo].[PROC_OBTENER_IEP] @idVaca = @numero_trazable_ultima_vaca, @IEP = @temporal_iep_vaca OUTPUT;
				END

				--Fecha última monta
				EXEC [dbo].[PROC_OBTENER_ULTIMA_MONTA] @numeroTrazableVaca = @numero_trazable_ultima_vaca, @fechaUltimaMonta = @temporal_ultima_monta OUTPUT;
				
				--Dias de gestación
				EXEC [dbo].[PROC_OBTENER_DIAS_GESTACION_RESTANTES] @numeroTrazableVaca = @numero_trazable_ultima_vaca, @diasGestacion = @temporal_dias_gestacion OUTPUT;
				
				--Fecha de parto
				EXEC [dbo].[PROC_OBTENER_FECHA_PARTO] @numeroTrazableVaca = @numero_trazable_ultima_vaca, @fechaParto = @temporal_fecha_parto OUTPUT;
				
				--Se insertan los datos de la vaca en los resultados
				INSERT INTO @resultado_resumen 
				VALUES (@numero_trazable_ultima_vaca, @temporal_nombre, @temporal_edad_primer_parto, @temporal_cantidad_partos, @temporal_edad_ultima_cria, @temporal_fecha_destete_ultima_cria, @temporal_iep_vaca, @temporal_ultimo_iep_vaca, @temporal_ultima_monta, @temporal_dias_gestacion, @temporal_fecha_parto);
				
				--Se incrementa el indice
				SET @indice_vacas = @indice_vacas + 1;

				--Se limpian los datos temporales
				SET @temporal_nombre = NULL;
				SET @temporal_cantidad_partos = NULL;
				SET @temporal_edad_primer_parto = NULL;
				SET @temporal_edad_ultima_cria = NULL;
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
