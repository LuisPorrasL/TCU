﻿CREATE PROCEDURE [dbo].[PROC_OBTENER_ULTIMO_IEP]
	@idVaca INT,
	@ultimoIEP INT OUTPUT -- Dias
AS
	BEGIN
		IF (SELECT COUNT(*) FROM [dbo].[PARTO] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca) > 1
		BEGIN
			DECLARE @penultimaFecha DATETIME;
			DECLARE @ultimaFecha DATETIME;

			SELECT TOP(1) @ultimaFecha = p.PK_FECHA FROM [dbo].[PARTO] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca ORDER BY p.PK_FECHA DESC;
			SELECT TOP(1) @penultimaFecha = p.PK_FECHA FROM [dbo].[PARTO] p WHERE p.PK_FK_NUMERO_TRAZABLE_VACA = @idVaca AND p.PK_FECHA <> @ultimaFecha ORDER BY p.PK_FECHA DESC;

			SELECT @ultimoIEP = DATEDIFF(DAY, @penultimaFecha, @ultimaFecha);
		END
		ELSE
		BEGIN
			SET @ultimoIEP = 0;
		END
	END