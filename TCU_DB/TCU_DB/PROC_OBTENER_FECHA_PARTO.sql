CREATE PROCEDURE [dbo].[PROC_OBTENER_FECHA_PARTO]
	@numeroTrazableVaca INT,
	@fechaParto DATETIME OUTPUT --Fecha de parto aproximada
AS
BEGIN
	--CONSTANTES
	DECLARE @CANTIDAD_MESES_PARTO INT = 9;

	DECLARE @fecha_ultima_monta DATETIME;

	EXEC [dbo].[PROC_OBTENER_ULTIMA_MONTA] @numeroTrazableVaca = @numeroTrazableVaca, @fechaUltimaMonta = @fecha_ultima_monta OUTPUT;
	IF @fecha_ultima_monta IS NOT NULL AND CAST(DATEDIFF(MONTH, @fecha_ultima_monta, GETDATE()) AS INT) <= @CANTIDAD_MESES_PARTO
	BEGIN
		SET @fechaParto = CAST(DATEADD(MONTH, @CANTIDAD_MESES_PARTO, @fecha_ultima_monta) AS INT);
	END
END
