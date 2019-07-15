CREATE PROCEDURE [dbo].[PROC_EDITAR_TORO]
	@numeroTrazableViejo INT,
	@numeroTrazableNuevo INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza NVARCHAR(30)
AS
	BEGIN
		UPDATE [dbo].[TORO]
		SET [NOMBRE] = @nombre, [CARACTERISTICAS] = @caracteristicas, [RAZA] = @raza
		WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazableViejo
		IF @numeroTrazableNuevo != @numeroTrazableViejo
			BEGIN
				UPDATE [dbo].[TORO]
				SET [PK_NUMERO_TRAZABLE] = @numeroTrazableNuevo
				WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazableViejo
			END
	END
