﻿CREATE PROCEDURE [dbo].[PROC_INSERTAR_CELO]
	@numeroTrazable INT,
	@fecha DATETIME
AS
	BEGIN
		INSERT INTO [dbo].[FECHAS_CELOS] ([PK_FK_NUMERO_TRAZABLE_VACA], [PK_FECHA])
		VALUES (@numeroTrazable, @fecha)
	END