CREATE PROCEDURE [dbo].[PROC_OBTENER_DIAS_GESTACION_RESTANTES]
	@numeroTrazableVaca INT,
	@diasGestacion INT OUTPUT -- Días de gestación restantes luego de la monta
AS
BEGIN
	--CONSTANTES
	DECLARE @CANTIDAD_MESES_PARTO INT = 9;

	DECLARE @fecha_ultima_monta DATETIME;

	EXEC [dbo].[PROC_OBTENER_ULTIMA_MONTA] @numeroTrazableVaca = @numeroTrazableVaca, @fechaUltimaMonta = @fecha_ultima_monta OUTPUT;
	IF @fecha_ultima_monta IS NOT NULL AND CAST(DATEDIFF(MONTH, @fecha_ultima_monta, GETDATE()) AS INT) <= @CANTIDAD_MESES_PARTO
	BEGIN
		SET @diasGestacion = CAST(DATEDIFF(DAY, @fecha_ultima_monta, GETDATE()) AS INT);
	END
END
