CREATE PROCEDURE [dbo].[PROC_INSERTAR_TORO]
	@numeroTrazable INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza NVARCHAR(30)

AS
	BEGIN
		INSERT INTO [dbo].[TORO]([PK_NUMERO_TRAZABLE], [NOMBRE], [CARACTERISTICAS], [RAZA]) 
		VALUES (@numeroTrazable, @nombre, @caracteristicas, @raza)
	END
