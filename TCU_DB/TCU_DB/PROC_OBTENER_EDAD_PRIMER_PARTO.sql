CREATE PROCEDURE [dbo].[PROC_OBTENER_EDAD_PRIMER_PARTO]
	@numeroTrazableVaca INT,
	@edadPrimerParto INT OUTPUT -- Edad de la vaca en su primer parto, meses
AS
	BEGIN
		DECLARE @fechaNacimiento DATETIME;
		DECLARE @cantidadPartos INT;
		DECLARE @fechaPrimerParto DATETIME;

		SELECT @fechaNacimiento = V.FECHA_NACIMIENTO FROM [dbo].[VACA] V WHERE V.PK_NUMERO_TRAZABLE = @numeroTrazableVaca;
		SELECT @cantidadPartos = COUNT (*) FROM [dbo].[PARTO] WHERE PK_FK_NUMERO_TRAZABLE_VACA = @numeroTrazableVaca;

		IF @cantidadPartos > 0 AND @fechaNacimiento IS NOT NULL
			BEGIN
				SELECT TOP(1) @fechaPrimerParto = P.PK_FECHA FROM [dbo].[PARTO] P WHERE P.PK_FK_NUMERO_TRAZABLE_VACA = @numeroTrazableVaca ORDER BY P.PK_FECHA ASC;
				SET @edadPrimerParto = CAST(DATEDIFF(MONTH, @fechaNacimiento, @fechaPrimerParto) AS INT);
			END
		ELSE
		BEGIN
			SET @edadPrimerParto = 0;
		END
	END
