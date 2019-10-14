CREATE PROCEDURE [dbo].[PROC_OBTENER_FECHA_DESTETE_ULTIMA_CRIA]
	@numeroTrazableVacaMadre INT,
	@fechaDesteteUltimaCria DATETIME OUTPUT -- Fecha de destete de la última cría
AS
BEGIN
	--Constantes
	DECLARE @CANTIDAD_MESES_DESTETE INT = 7;

	DECLARE @fechaNacimientoUltimaCria DATETIME;
	DECLARE @edadUltimaCria INT;

	SELECT TOP(1) @fechaNacimientoUltimaCria = V.FECHA_NACIMIENTO FROM [dbo].[VACA] V WHERE V.ACTIVA = 1 AND V.FK_NUMERO_TRAZABLE_VACA = @numeroTrazableVacaMadre ORDER BY V.FECHA_NACIMIENTO DESC;
	IF @fechaNacimientoUltimaCria IS NOT NULL
	BEGIN
		EXEC [dbo].[PROC_OBTENER_EDAD_ULTIMA_CRIA] @numeroTrazableVacaMadre, @edadUltimaCria OUTPUT;
		IF @edadUltimaCria IS NOT NULL AND @edadUltimaCria < 7
		BEGIN
			SET @fechaDesteteUltimaCria = CAST(DATEADD(MONTH, @CANTIDAD_MESES_DESTETE, @fechaNacimientoUltimaCria) AS INT);
		END
	END
END
