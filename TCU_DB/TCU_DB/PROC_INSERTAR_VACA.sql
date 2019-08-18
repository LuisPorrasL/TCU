CREATE PROCEDURE [dbo].[PROC_INSERTAR_VACA]
	@numeroTrazable INT,
	@nombre NVARCHAR(20),
	@caracteristicas NVARCHAR(MAX),
	@raza INT,
	@fechaNacimiento DATETIME,
	@fkModoPrennes INT,
	@fkNumeroTrazableMadre INT,
	@fkNumeroTrazablePadre INT,
	@peso DECIMAL(5,2),
	@fkDesarrollo INT
AS
	BEGIN
		INSERT INTO [dbo].[VACA]([PK_NUMERO_TRAZABLE], [NOMBRE], [CARACTERISTICAS], [FK_ID_RAZA], [FECHA_NACIMIENTO], [FK_ID_MODO_PRENNES], [FK_NUMERO_TRAZABLE_VACA], [FK_NUMERO_TRAZABLE_TORO], [PESO], [FK_ID_DESARROLLO], [ACTIVA]) 
		VALUES (@numeroTrazable, @nombre, @caracteristicas, @raza, @fechaNacimiento, @fkModoPrennes, @fkNumeroTrazableMadre, @fkNumeroTrazablePadre, @peso, @fkDesarrollo, 'True')
	END
