CREATE PROCEDURE [dbo].[PROC_EDITAR_VACA]
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
		UPDATE [dbo].[VACA]
		SET [NOMBRE] = @nombre, [CARACTERISTICAS] = @caracteristicas, [FK_ID_RAZA] = @raza, [PESO] = @peso, [FECHA_NACIMIENTO] = @fechaNacimiento, [FK_ID_MODO_PRENNES] = @fkModoPrennes, [FK_NUMERO_TRAZABLE_VACA] = @fkNumeroTrazableMadre, [FK_NUMERO_TRAZABLE_TORO] = @fkNumeroTrazablePadre, [FK_ID_DESARROLLO] = @fkDesarrollo
		WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
	END
