CREATE PROCEDURE [dbo].[PROC_INSERTAR_TORO]
	@numeroTrazable INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza INT

AS
	BEGIN
		INSERT INTO [dbo].[TORO]([PK_NUMERO_TRAZABLE], [NOMBRE], [CARACTERISTICAS], [FK_ID_RAZA], [ACTIVA]) 
		VALUES (@numeroTrazable, @nombre, @caracteristicas, @raza, 1)
	END
