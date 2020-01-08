CREATE PROCEDURE [dbo].[PROC_OBTENER_PROMEDIO_PARTOS_HATO]
	@promedioPartosHato DECIMAL(3,1) OUTPUT -- Promedio de partos del hato
AS
BEGIN
	DECLARE @cantidadHembras INT;
	DECLARE @cantidadPartos INT;
    SELECT @cantidadHembras = COUNT (V.PK_NUMERO_TRAZABLE) FROM [dbo].[VACA] V
	SELECT @cantidadPartos = COUNT (*) FROM [dbo].[PARTO]

	SET @promedioPartosHato = @cantidadPartos / CAST(@cantidadHembras AS DECIMAL(3,1));

END
