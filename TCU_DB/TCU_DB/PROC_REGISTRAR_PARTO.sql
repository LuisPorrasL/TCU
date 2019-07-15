CREATE PROCEDURE [dbo].[PROC_REGISTRAR_PARTO]
	@numeroTrazableMadre INT,
	@fecha DATETIME,
	@numeroTrazablePadre INT,
	@muertePrematura BIT,
	@sexo CHAR,
	@causaAborto NVARCHAR(MAX)
AS
	BEGIN
		INSERT INTO [dbo].[PARTO]([PK_FK_NUMERO_TRAZABLE_VACA], [PK_FECHA], [FK_NUMERO_TRAZABLE_TORO], [MUERTE_PREMATURA], [SEXO], [CAUSA_ABORTO])
		VALUES(@numeroTrazableMadre, @fecha, @numeroTrazablePadre, @muertePrematura, @sexo, @causaAborto)
	END
