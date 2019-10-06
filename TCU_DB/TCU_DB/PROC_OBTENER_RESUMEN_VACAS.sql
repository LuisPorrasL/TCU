CREATE PROCEDURE [dbo].[PROC_OBTENER_RESUMEN_VACAS]
AS
	BEGIN
		DECLARE @resultado_resumen TIPO_RESUMEN_VACAS
		INSERT INTO @resultado_resumen 
		VALUES (0,'PRUEBA', null, null, null, null, null, null, null)

		SELECT * FROM @resultado_resumen
	END
