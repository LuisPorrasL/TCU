CREATE PROCEDURE [dbo].[PROC_OBTENER_IEP_PERIODO]
	@idVaca INT,
	@fechaInicioPeriodo DATETIME,
	@fechaFinPeriodo DATETIME,
	@IEP DECIMAL(8,2) OUTPUT -- Dias
AS
	BEGIN
		DECLARE @cantidadPartos INT;
		SELECT @cantidadPartos = COUNT(*) FROM [dbo].[PARTO] p INNER JOIN [dbo].[VACA] v ON p.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA >= @fechaInicioPeriodo AND p.PK_FECHA <= @fechaFinPeriodo AND (v.FECHA_NACIMIENTO <= @fechaFinPeriodo AND (v.FECHA_DE_BAJA >= @fechaInicioPeriodo OR v.FECHA_DE_BAJA IS NULL));
		IF (@cantidadPartos) > 1
		BEGIN
			DECLARE @indiceFechas INT = 0;
			DECLARE @fechaMenor DATETIME = CAST ('1900-01-01' AS DATETIME);
			DECLARE @fechaMayor DATETIME;
			DECLARE @tmp INT;
			DECLARE @sumatoria INT = 0;
			WHILE @indiceFechas <= (@cantidadPartos - 2)
			BEGIN
				SELECT TOP(1) @fechaMenor = p.PK_FECHA FROM [dbo].[PARTO] p INNER JOIN [dbo].[VACA] v ON p.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA >= @fechaInicioPeriodo AND p.PK_FECHA <= @fechaFinPeriodo AND p.PK_FECHA > @fechaMenor AND (v.FECHA_NACIMIENTO <= @fechaFinPeriodo AND (v.FECHA_DE_BAJA >= @fechaInicioPeriodo OR v.FECHA_DE_BAJA IS NULL)) ORDER BY p.PK_FECHA ASC;
				SELECT TOP(1) @fechaMayor = p.PK_FECHA FROM [dbo].[PARTO] p INNER JOIN [dbo].[VACA] v ON p.PK_FK_NUMERO_TRAZABLE_VACA = v.PK_NUMERO_TRAZABLE WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA >= @fechaInicioPeriodo AND p.PK_FECHA <= @fechaFinPeriodo AND p.PK_FECHA > @fechaMenor AND (v.FECHA_NACIMIENTO <= @fechaFinPeriodo AND (v.FECHA_DE_BAJA >= @fechaInicioPeriodo OR v.FECHA_DE_BAJA IS NULL)) ORDER BY p.PK_FECHA ASC;

				SELECT @tmp = DATEDIFF(DAY, @fechaMenor, @fechaMayor);

				SET @sumatoria = @sumatoria + @tmp;
				SET @indiceFechas = @indiceFechas + 1;
			END
			SET @IEP = @sumatoria / CAST (@cantidadPartos AS DECIMAL(8,2));
		END
		ELSE
		BEGIN
			SET @IEP = CAST (0.0 AS DECIMAL(8,2));
		END
	END
