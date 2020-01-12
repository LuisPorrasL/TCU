CREATE PROCEDURE [dbo].[PROC_REGISTRAR_PALPACION]
	@numeroTrazable INT,
	@fecha DATETIME,
	@condicionCorporal DECIMAL(2,1),
	@confirmacion BIT,
	@resultado NVARCHAR(30)

AS
	BEGIN
		INSERT INTO [dbo].[PALPACION]([PK_FK_NUMERO_TRAZABLE_VACA], [PK_FECHA], [CONDICION_CORPORAL], [CONFIRMACION], [RESULTADO]) 
		VALUES (@numeroTrazable, @fecha, @condicionCorporal, @confirmacion, @resultado)
		IF @confirmacion = 0
		BEGIN
			UPDATE [dbo].[VACA]
			SET [FK_ID_MODO_PRENNES] = (SELECT mP.PK_ID_MODO_PRENNES FROM [dbo].[MODO_PRENNES] mP WHERE mP.MODO_PRENNES = 'No preñada')
			WHERE [PK_NUMERO_TRAZABLE] = @numeroTrazable
		END
	END
