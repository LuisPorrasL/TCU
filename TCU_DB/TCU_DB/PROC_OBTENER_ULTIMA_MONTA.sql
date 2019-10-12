CREATE PROCEDURE [dbo].[PROC_OBTENER_ULTIMA_MONTA]
	@numeroTrazableVaca INT,
	@fechaUltimaMonta DATETIME OUTPUT -- Fecha de la última monta de la vaca
AS
BEGIN
	SELECT TOP(1) @fechaUltimaMonta = M.PK_FECHA FROM [dbo].[FECHAS_CELOS] M WHERE M.PK_FK_NUMERO_TRAZABLE_VACA = @numeroTrazableVaca ORDER BY M.PK_FECHA DESC;
END
