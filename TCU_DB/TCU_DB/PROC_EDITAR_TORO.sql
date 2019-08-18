CREATE PROCEDURE [dbo].[PROC_EDITAR_TORO]
	@numeroTrazable INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza INT
AS
	BEGIN
		UPDATE [dbo].[TORO]
		SET [NOMBRE] = @nombre, [CARACTERISTICAS] = @caracteristicas, [FK_ID_RAZA] = @raza
		WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
	END
