﻿CREATE TYPE [dbo].[TIPO_DATOS_GRAFICOS_VACAS] AS TABLE
(
	[NUMERO_TRAZABLE]			INT				NOT NULL,
	[CANTIDAD_PARTOS]			INT				NULL,
	[IEP_VACA_MESES]			DECIMAL(8, 2)	NULL,
	[ULTIMO_IEP_VACA_MESES]		DECIMAL(8, 2)	NULL
)
