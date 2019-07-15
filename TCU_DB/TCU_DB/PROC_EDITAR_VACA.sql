﻿CREATE PROCEDURE [dbo].[PROC_EDITAR_VACA]
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
		UPDATE [dbo].[VACA]
		SET [NOMBRE] = @nombre, [CARACTERISTICAS] = @caracteristicas, [RAZA] = @raza, [FECHA_NACIMIENTO] = @fechaNacimiento, [FK_ID_MODO_PRENNES] = @fkModoPrennes, [FK_NUMERO_TRAZABLE_VACA] = @fkNumeroTrazableMadre, [FK_NUMERO_TRAZABLE_TORO] = @fkNumeroTrazablePadre
		WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
	END