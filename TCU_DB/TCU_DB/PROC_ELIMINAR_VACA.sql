CREATE PROCEDURE [dbo].[PROC_ELIMINAR_VACA]
	@numeroTrazable INT,
	@causaDeBaja	NVARCHAR(MAX)
AS
	BEGIN
		UPDATE dbo.[VACA]
		SET ACTIVA = 'False', CAUSA_DE_BAJA = @causaDeBaja
		WHERE PK_NUMERO_TRAZABLE = @numeroTrazable;
	END
