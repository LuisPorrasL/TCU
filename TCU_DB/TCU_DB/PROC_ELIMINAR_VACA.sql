CREATE PROCEDURE [dbo].[PROC_ELIMINAR_VACA]
	@numeroTrazable INT,
	@fechaDeBaja	DATETIME,
	@causaDeBaja	NVARCHAR(MAX)
AS
	BEGIN
		UPDATE dbo.[VACA]
		SET ACTIVA = 0, CAUSA_DE_BAJA = @causaDeBaja, FECHA_DE_BAJA = @fechaDeBaja
		WHERE PK_NUMERO_TRAZABLE = @numeroTrazable;
	END
