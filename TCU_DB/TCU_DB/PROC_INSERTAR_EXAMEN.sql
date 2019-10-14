CREATE PROCEDURE [dbo].[PROC_INSERTAR_EXAMEN]

    @numeroTrazable INT,
	@fecha DATETIME,
	@condCorp NVARCHAR(30),
	@libido BIT,
	@capacidadM BIT,
	@descansoSexual INT,
	@prepucio BIT,
	@pene BIT,
	@testiculos BIT,
	@epididimos BIT,
	@glandulasB BIT,
	@prostata BIT,
	@vesiculasS BIT,
	@ampulas BIT,
	@circunferenciaEsc	NUMERIC(6,3),
	@volumenEyaculado	NUMERIC(6,3),
	@concentracion NVARCHAR(50),
	@motilidadMasal INT,
	@motilidadProgresiva INT,
	@morfologiaNormal INT,
	@anormalidadesP NVARCHAR(MAX),
	@dannosAcrosomales NVARCHAR(MAX),
	@anormalidadesS NVARCHAR(MAX),
	@totalAnormalidades INT,
	@anomaliaFrecuente VARCHAR(MAX),
	@leucocitos INT,
	@celulasEpit INT,
	@observaciones NVARCHAR(MAX),
	@satisfactorio BIT,
	@veterinario NVARCHAR(30),
	@palpacion BIT,
	@ecografia BIT,
	@vaginaArt BIT,
	@electroEya BIT,
	@protusion BIT


AS
BEGIN
	
		INSERT INTO [dbo].[EXAMEN_ANTROPOLOGICO]([PK_FK_NUMERO_TRAZABLE_TORO],[PK_FECHA],[CONDICION_CORPORAL],[LIBIDO],[CAPACIDAD_DE_MONTA],[DESCANSO_SEXUAL],[PREPUCIO],[PENE],[TESTICULOS],[EPIDIDIMOS],[GLANDULAS_BULBOURETRALES],[PROSTATA],[VESICULAS_SEMINALES],[AMPULAS],[CIRCUNFERENCIA_ESCROTAL],[VOLUMEN_EYACULADO],[CONCENTRACION],[MOTILIDAD_MASAL],[MOTILIDAD_PROGRESIVA_RAPIDA],[MORFOLOGIA_NORMAL],[ANORMALIDADES_PRIMARIAS],[DANNOS_ACROSOMALES],[ANORMALIDADES_SECUNDARIAS],[TOTAL_ANORMALIDADES],[ANOMALIA_MAS_FRECUENTE],[LEUCOCITOS],[CEDULAS_EPITELEALES],[OBSERVACIONES],[SATISFACTORIO],[VETERINARIO],[Palpacion],[Ecografia],[VaginaArt],[ElectroEya],[Protusion])
		VALUES (@numeroTrazable, @fecha, @condCorp, @libido, @capacidadM, @descansoSexual, @prepucio, @pene, @testiculos, @epididimos, @glandulasB, @prostata, @vesiculasS, @ampulas, @circunferenciaEsc, @volumenEyaculado,
		@concentracion, @motilidadMasal, @motilidadProgresiva, @morfologiaNormal, @anormalidadesP, @dannosAcrosomales, @anormalidadesS, @totalAnormalidades, @anomaliaFrecuente, @leucocitos, @celulasEpit, @observaciones, @satisfactorio, @veterinario, @palpacion, @ecografia, @vaginaArt, @electroEya, @protusion )
	END
