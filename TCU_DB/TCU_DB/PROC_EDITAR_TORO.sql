CREATE PROCEDURE [dbo].[PROC_EDITAR_TORO]
	@numeroTrazable INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza NVARCHAR(30)
AS
	BEGIN
		UPDATE [dbo].[TORO]
		SET [NOMBRE] = @nombre, [CARACTERISTICAS] = @caracteristicas, [RAZA] = @raza
		WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
	END
