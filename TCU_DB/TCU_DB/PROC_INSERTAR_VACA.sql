CREATE PROCEDURE [dbo].[PROC_INSERTAR_VACA]
	@numeroTrazable INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza NVARCHAR(30),
	@fechaNacimiento DATETIME,
	@fkModoPrennes INT,
	@fkNumeroTrazableMadre INT,
	@fkNumeroTrazablePadre INT
AS
	BEGIN
		INSERT INTO [dbo].[VACA]([PK_NUMERO_TRAZABLE], [NOMBRE], [CARACTERISTICAS], [RAZA], [FECHA_NACIMIENTO], [FK_ID_MODO_PRENNES], [FK_NUMERO_TRAZABLE_VACA], [FK_NUMERO_TRAZABLE_TORO]) 
		VALUES (@numeroTrazable, @nombre, @caracteristicas, @raza, @fechaNacimiento, @fkModoPrennes, @fkNumeroTrazableMadre, @fkNumeroTrazablePadre)
	END
