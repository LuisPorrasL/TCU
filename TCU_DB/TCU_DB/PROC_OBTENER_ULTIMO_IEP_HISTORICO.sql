CREATE PROCEDURE [dbo].[PROC_OBTENER_ULTIMO_IEP_HISTORICO]
	@ultimoIEPHistorico DECIMAL(5,2) = 0.0 OUTPUT -- Dias
AS
	BEGIN
		DECLARE @cantidadVacas INT;
		SELECT @cantidadVacas = COUNT(v.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] v;
		IF @cantidadVacas > 0
		BEGIN
			SELECT @cantidadVacas;
			DECLARE @indiceVacas INT = 0;
			DECLARE @idVacaParam INT = -1;
			DECLARE @tmp INT;
			DECLARE @sumatoria INT;
			WHILE @indiceVacas < @cantidadVacas
			BEGIN
				SELECT TOP(1) @idVacaParam = v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.PK_NUMERO_TRAZABLE > @idVacaParam ORDER BY v.PK_NUMERO_TRAZABLE ASC;
				EXEC [dbo].[PROC_OBTENER_ULTIMO_IEP] @idVaca = @idVacaParam, @ultimoIEP = @tmp OUTPUT;

				SET @sumatoria = @sumatoria + @tmp;
				SET @indiceVacas = @indiceVacas + 1;
			END
			SET @ultimoIEPHistorico = @sumatoria / CAST(@cantidadVacas AS DECIMAL(5,2));
		END
	END