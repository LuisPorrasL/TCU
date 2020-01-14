CREATE PROCEDURE [dbo].[PROC_OBTENER_ULTIMO_IEP_HISTORICO_PERIODO]
	@fechaInicio DATETIME,
	@fechaFin DATETIME,
	@ultimoIEPHistoricoPeriodo DECIMAL(8,2) OUTPUT -- Dias
AS
	BEGIN
		DECLARE @cantidadVacas INT;
		SELECT @cantidadVacas = COUNT(v.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] v WHERE v.FECHA_NACIMIENTO <= @fechaFin AND (v.FECHA_DE_BAJA >= @fechaInicio OR v.FECHA_DE_BAJA IS NULL);
		IF @cantidadVacas > 0
		BEGIN
			DECLARE @indiceVacas INT = 0;
			DECLARE @idVacaParam INT = -1;
			DECLARE @tmp INT;
			DECLARE @sumatoria INT = 0;
			WHILE @indiceVacas < @cantidadVacas
			BEGIN
				SELECT TOP(1) @idVacaParam = v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.PK_NUMERO_TRAZABLE > @idVacaParam AND (v.FECHA_NACIMIENTO <= @fechaFin AND (v.FECHA_DE_BAJA >= @fechaInicio OR v.FECHA_DE_BAJA IS NULL)) ORDER BY v.PK_NUMERO_TRAZABLE ASC;
				EXEC [dbo].[PROC_OBTENER_ULTIMO_IEP_PERIODO] @idVaca = @idVacaParam, @fechaInicioPeriodo = @fechaInicio, @fechaFinPeriodo = @fechaFin, @ultimoIEP = @tmp OUTPUT;

				SET @sumatoria = @sumatoria + @tmp;
				SET @indiceVacas = @indiceVacas + 1;
			END
			SET @ultimoIEPHistoricoPeriodo = @sumatoria / CAST(@cantidadVacas AS DECIMAL(8,2));
		END
		ELSE
		BEGIN
			SET @ultimoIEPHistoricoPeriodo = CAST (0.0 AS DECIMAL(8,2));
		END
	END
