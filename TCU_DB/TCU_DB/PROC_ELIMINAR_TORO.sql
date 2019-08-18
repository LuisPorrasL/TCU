CREATE PROCEDURE [dbo].[PROC_ELIMINAR_TORO]
	@numeroTrazable INT,
	@causaDeBaja	NVARCHAR(MAX)
AS
	BEGIN
		UPDATE dbo.[TORO]
		SET ACTIVA = 'False', CAUSA_DE_BAJA = @causaDeBaja
		WHERE PK_NUMERO_TRAZABLE = @numeroTrazable;
	END
