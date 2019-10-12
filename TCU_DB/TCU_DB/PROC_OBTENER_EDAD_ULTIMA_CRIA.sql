CREATE PROCEDURE [dbo].[PROC_OBTENER_EDAD_ULTIMA_CRIA]
	@numeroTrazableVaca INT,
	@edadUltimaCria INT OUTPUT -- Edad de la última cría de la vaca, meses
AS
BEGIN
	DECLARE @cantidadPartos INT;
	DECLARE @fechaNacimientoUltimaCria DATETIME;

	SELECT @cantidadPartos = COUNT (*) FROM [dbo].[PARTO] WHERE PK_FK_NUMERO_TRAZABLE_VACA = @numeroTrazableVaca;
	IF @cantidadPartos > 0
	BEGIN
		SELECT TOP(1) @fechaNacimientoUltimaCria = V.FECHA_NACIMIENTO FROM [dbo].[VACA] V WHERE V.ACTIVA = 1 AND V.FK_NUMERO_TRAZABLE_VACA = @numeroTrazableVaca ORDER BY V.FECHA_NACIMIENTO DESC;
		IF @fechaNacimientoUltimaCria IS NOT NULL
		BEGIN
			SET @edadUltimaCria = CAST(DATEDIFF(MONTH, @fechaNacimientoUltimaCria, GETDATE()) AS INT);
		END
	END
END
