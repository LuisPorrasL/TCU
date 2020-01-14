CREATE PROCEDURE [dbo].[PROC_OBTENER_IEP_HISTORICO]
	@IEPHistorico DECIMAL(8,2) OUTPUT -- Días
AS
	BEGIN
		DECLARE @cantidadVacas INT;
		SELECT @cantidadVacas = COUNT(v.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] v WHERE v.ACTIVA = 1;
		IF @cantidadVacas > 0
		BEGIN
			DECLARE @indiceVacas INT = 0;
			DECLARE @idVacaParam INT = -1;
			DECLARE @tmp DECIMAL(8,2);
			DECLARE @sumatoria DECIMAL(8,2) = CAST (0.0 AS DECIMAL(8,2));
			WHILE @indiceVacas < @cantidadVacas
			BEGIN
				SELECT TOP(1) @idVacaParam = v.PK_NUMERO_TRAZABLE FROM [dbo].[VACA] v WHERE v.PK_NUMERO_TRAZABLE > @idVacaParam AND v.ACTIVA = 1 ORDER BY v.PK_NUMERO_TRAZABLE ASC;
				EXEC [dbo].[PROC_OBTENER_IEP] @idVaca = @idVacaParam, @IEP = @tmp OUTPUT;

				SET @sumatoria = @sumatoria + @tmp;
				SET @indiceVacas = @indiceVacas + 1;
			END
			SET @IEPHistorico = @sumatoria / CAST(@cantidadVacas AS DECIMAL(8,2));
		END
		ELSE
		BEGIN
			SET @IEPHistorico = CAST (0.0 AS DECIMAL(8,2));
		END
	END
