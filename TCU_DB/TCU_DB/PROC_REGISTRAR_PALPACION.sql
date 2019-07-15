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
	END
