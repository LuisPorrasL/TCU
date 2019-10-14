﻿CREATE TABLE [dbo].[EXAMEN_ANTROPOLOGICO]
(
	[PK_FK_NUMERO_TRAZABLE_TORO]	INT				NOT NULL,
	[PK_FECHA]					DATETIME		NOT NULL,
	[CONDICION_CORPORAL]		VARCHAR(MAX)	NULL,
	[LIBIDO]					BIT				NULL,
	[CAPACIDAD_DE_MONTA]		BIT				NULL,
	[DESCANSO_SEXUAL]			INT				NOT NULL,
	[PREPUCIO]					BIT				NULL,
	[PENE]						BIT				NULL,
	[TESTICULOS]				BIT				NULL,
	[EPIDIDIMOS]				BIT				NULL,
	[GLANDULAS_BULBOURETRALES]	BIT				NULL,
	[PROSTATA]					BIT				NULL,
	[VESICULAS_SEMINALES]		BIT				NULL,
	[AMPULAS]					BIT				NULL,
	[CIRCUNFERENCIA_ESCROTAL]	NUMERIC(6,3)	NULL,
	[VOLUMEN_EYACULADO]			NUMERIC(6,3)	NULL,
	[CONCENTRACION]				NVARCHAR(50)	NULL,
	[MOTILIDAD_MASAL]			INT				NULL,
	[MOTILIDAD_PROGRESIVA_RAPIDA]	INT			NULL,
	[MORFOLOGIA_NORMAL]			INT				NULL,
	[ANORMALIDADES_PRIMARIAS]	NVARCHAR(MAX)				NULL,
	[DANNOS_ACROSOMALES]		NVARCHAR(MAX)				NULL,
	[ANORMALIDADES_SECUNDARIAS]	VARCHAR(MAX)				NULL,
	[TOTAL_ANORMALIDADES]		INT				NULL,
	[ANOMALIA_MAS_FRECUENTE]	NVARCHAR(MAX)	NULL,
	[LEUCOCITOS]				INT				NULL,
	[CEDULAS_EPITELEALES]		INT				NULL,
	[OBSERVACIONES]				NVARCHAR(MAX)	NULL,
	[SATISFACTORIO]				BIT				NOT NULL,
	[VETERINARIO]				NVARCHAR(60)	NULL,
	[Palpacion] BIT NULL, 
    [Ecografia] BIT NULL, 
    [VaginaArt] BIT NULL, 
    [ElectroEya] BIT NULL, 
    [Protusion] BIT NULL, 
    CONSTRAINT CK_PK_EXAMEN_ANDROLOGICO PRIMARY KEY CLUSTERED (Pk_FK_NUMERO_TRAZABLE_TORO, PK_FECHA),
	CONSTRAINT CK_FK_NUMERO_TRAZABLE_TORO_EXAMEN FOREIGN KEY(PK_FK_NUMERO_TRAZABLE_TORO)
		REFERENCES dbo.TORO(PK_NUMERO_TRAZABLE) ON UPDATE CASCADE ON DELETE CASCADE
)
