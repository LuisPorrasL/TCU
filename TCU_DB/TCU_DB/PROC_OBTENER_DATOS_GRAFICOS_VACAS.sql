CREATE PROCEDURE [dbo].[PROC_OBTENER_DATOS_GRAFICOS_VACAS]
AS
BEGIN
	DECLARE @cantidad_vacas INT;
	DECLARE @datos_vacas TIPO_DATOS_GRAFICOS_VACAS;

	--Se obtiene la cantidad de vacas registradas
	SELECT @cantidad_vacas = COUNT (*) FROM [dbo].[VACA];
	IF @cantidad_vacas > 0
	BEGIN
		DECLARE @indice_vacas INT = 0;
		DECLARE @numero_trazable_ultima_vaca INT = -1;
		DECLARE @cantidad_partos_vaca INT;
		DECLARE @iep_vaca DECIMAL (3, 1);
		DECLARE @ultimo_iep_vaca DECIMAL (3, 1);

		--Se obtiene la información de todas las vacas
		WHILE @indice_vacas < @cantidad_vacas
		BEGIN
			SELECT TOP(1) @numero_trazable_ultima_vaca = V.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] V WHERE V.PK_NUMERO_TRAZABLE > @numero_trazable_ultima_vaca ORDER BY V.PK_NUMERO_TRAZABLE ASC;

			SELECT @cantidad_partos_vaca = COUNT (*) FROM [dbo].[PARTO] P WHERE P.PK_FK_NUMERO_TRAZABLE_VACA = @numero_trazable_ultima_vaca;

			EXEC [dbo].[PROC_OBTENER_IEP] @idVaca = @numero_trazable_ultima_vaca, @IEP = @iep_vaca OUTPUT;

			EXEC [dbo].[PROC_OBTENER_ULTIMO_IEP] @idVaca = @numero_trazable_ultima_vaca, @ultimoIEP = @ultimo_iep_vaca OUTPUT;

			--Se insertan los datos de la vaca en los resultados
			INSERT INTO @datos_vacas 
			VALUES (@numero_trazable_ultima_vaca, @cantidad_partos_vaca, @iep_vaca, @ultimo_iep_vaca)

			--Se incrementa el indice
			SET @indice_vacas = @indice_vacas + 1;

			--Se limpian los datos temporales
			SET @cantidad_partos_vaca = NULL;
			SET @iep_vaca = NULL;
			SET @ultimo_iep_vaca = NULL;
		END

	END
	--Se realiza la consulta a devolver
	SELECT * FROM @datos_vacas
END
