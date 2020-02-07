CREATE PROCEDURE [dbo].[PROC_OBTENER_ULTIMO_IEP_PERIODO]
	@idVaca INT,
	@fechaInicioPeriodo DATETIME,
	@fechaFinPeriodo DATETIME,
	@ultimoIEP INT OUTPUT -- Dias
AS
	BEGIN
		IF (SELECT COUNT(*) FROM [dbo].[PARTO] p INNER JOIN [dbo].[VACA] v ON p.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA >= @fechaInicioPeriodo AND p.PK_FECHA <= @fechaFinPeriodo AND (v.FECHA_NACIMIENTO <= @fechaFinPeriodo AND (v.FECHA_DE_BAJA >= @fechaInicioPeriodo OR v.FECHA_DE_BAJA IS NULL))) > 1
		BEGIN
			DECLARE @penultimaFecha DATETIME;
			DECLARE @ultimaFecha DATETIME;

			SELECT TOP(1) @ultimaFecha = p.PK_FECHA FROM [dbo].[PARTO] p INNER JOIN [dbo].[VACA] v ON p.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA >= @fechaInicioPeriodo AND p.PK_FECHA <= @fechaFinPeriodo AND (v.FECHA_NACIMIENTO <= @fechaFinPeriodo AND (v.FECHA_DE_BAJA >= @fechaInicioPeriodo OR v.FECHA_DE_BAJA IS NULL)) ORDER BY p.PK_FECHA DESC;
			SELECT TOP(1) @penultimaFecha = p.PK_FECHA FROM [dbo].[PARTO] p INNER JOIN [dbo].[VACA] v ON p.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA >= @fechaInicioPeriodo AND p.PK_FECHA <= @fechaFinPeriodo AND p.PK_FECHA <> @ultimaFecha AND (v.FECHA_NACIMIENTO <= @fechaFinPeriodo AND (v.FECHA_DE_BAJA >= @fechaInicioPeriodo OR v.FECHA_DE_BAJA IS NULL)) ORDER BY p.PK_FECHA DESC;

			SELECT @ultimoIEP = DATEDIFF(DAY, @penultimaFecha, @ultimaFecha);
		END
		ELSE
		BEGIN
			SET @ultimoIEP = 0;
		END
	END
