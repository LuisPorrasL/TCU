/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM [dbo].[USUARIO]
DELETE FROM [dbo].[VACA]
DELETE FROM [dbo].[TORO]
DELETE FROM [dbo].[MODO_PRENNES]
DELETE FROM [dbo].[RAZA]
DELETE FROM [dbo].[DESARROLLO]
DELETE FROM [dbo].[FECHAS_CELOS]
DELETE FROM [dbo].[FECHAS_DESTETES]
DELETE FROM [dbo].[PALPACION]
DELETE FROM [dbo].[PARTO]
DELETE FROM [dbo].[EXAMEN_ANTROPOLOGICO]

--Datos reales
SET IDENTITY_INSERT dbo.[MODO_PRENNES] ON
INSERT INTO [dbo].[MODO_PRENNES] ([PK_ID_MODO_PRENNES], [MODO_PRENNES]) 
VALUES	(1, 'No preñada'),
		(2, 'Transferencia de embriones'),
		(3, 'Monto natural'),
		(4, 'IA TD'),
		(5, 'IA');
SET IDENTITY_INSERT dbo.[MODO_PRENNES] OFF

SET IDENTITY_INSERT dbo.[RAZA] ON
INSERT INTO dbo.[RAZA] ([PK_ID_RAZA], [RAZA])
VALUES	(1, 'Desconocida'),
		(2, 'Holstein'), 
		(3, 'Holstein Rojo'),
		(4, 'Jersey'),
		(5, 'Pardo Suizo'),
		(6, 'Guernsey'),
		(7, 'Ayrshire'),
		(8, 'Brahman'),
		(9, 'Nelore'),
		(10, 'Gyr'),
		(11, 'Gyrolando'),
		(12, 'Guzerat'),
		(13, 'Angus'),
		(14, 'Charolaise'),
		(15, 'Limousine'),
		(16, 'Blonde D’Aquitaine'),
		(17, 'Simmental'),
		(18, 'Wagyu'),
		(19, 'Brangus'),
		(20, 'Simbrah'),
		(21, 'Charbray'),
		(22, 'Senepol'),
		(23, 'Sueco Rojo'),
		(24, 'Chumeca');
SET IDENTITY_INSERT dbo.[RAZA] OFF

SET IDENTITY_INSERT dbo.[DESARROLLO] ON
INSERT INTO dbo.[DESARROLLO] ([PK_ID_DESARROLLO], [ESTADO])
VALUES	(1, 'Ternera'),
		(2, 'Novilla'),
		(3, 'Vaca');
SET IDENTITY_INSERT dbo.[DESARROLLO] OFF

--Datos de prueba
INSERT INTO [dbo].[VACA]([PK_NUMERO_TRAZABLE], [NOMBRE], [CARACTERISTICAS], [FK_ID_RAZA], [FECHA_NACIMIENTO], [FK_ID_MODO_PRENNES], [FK_NUMERO_TRAZABLE_VACA], [FK_NUMERO_TRAZABLE_TORO], [PESO], [FK_ID_DESARROLLO], [ACTIVA], [CAUSA_DE_BAJA])
VALUES	(447, 'Mojarra', 'Real', 2, '2007-01-20', 2, NULL, NULL, 300, 3, 1, NULL),
		(451, 'Volillera', 'Real', 2, '2007-03-07', 2, NULL, NULL, 300, 3, 1, NULL),
		(457, 'Baya', 'Real', 2, '2007-10-06', 2, NULL, NULL, 300, 3, 1, NULL),
		(500, 'Reciente', 'Fake', 1, '2019-10-07 18:13:53', 2, 447, NULL, 300, 3, 1, NULL),
		(509, 'Vieja', 'Fake', 1, '2019-03-19 18:14:40', 2, 457, NULL, 300, 3, 1, NULL);

INSERT INTO [dbo].[PARTO]([PK_FK_NUMERO_TRAZABLE_VACA], [PK_FECHA], [FK_NUMERO_TRAZABLE_TORO], [SEXO], [MUERTE_PREMATURA], [CAUSA_ABORTO])
VALUES	(447, '2009-08-09', NULL, 'H', 0, NULL),
		(447, '2010-12-27', NULL, 'H', 0, NULL),
		(447, '2012-01-06', NULL, 'H', 0, NULL),
		(447, '2013-03-01', NULL, 'H', 0, NULL),
		(447, '2014-01-23', NULL, 'H', 0, NULL),
		(447, '2015-02-15', NULL, 'H', 0, NULL),
		(447, '2016-04-01', NULL, 'H', 0, NULL),
		(447, '2017-10-10', NULL, 'H', 0, NULL),
		(447, '2018-10-13', NULL, 'M', 1, 'Desconocida'),
		(451, '2009-08-07', NULL, 'M', 0, NULL),
		(451, '2011-01-21', NULL, 'M', 0, NULL),
		(451, '2013-03-17', NULL, 'M', 0, NULL),
		(451, '2014-06-05', NULL, 'M', 0, NULL),
		(451, '2015-12-31', NULL, 'M', 0, NULL),
		(451, '2018-01-24', NULL, 'M', 0, NULL),
		(457, '2010-05-16', NULL, 'H', 0, NULL),
		(457, '2012-03-08', NULL, 'H', 0, NULL),
		(457, '2014-03-19', NULL, 'H', 0, NULL),
		(457, '2015-04-12', NULL, 'H', 0, NULL),
		(457, '2016-04-16', NULL, 'H', 0, NULL),
		(457, '2017-04-11', NULL, 'H', 0, NULL),
		(457, '2018-01-20', NULL, 'H', 0, NULL),
		(457, '2018-05-26', NULL, 'H', 0, NULL);

INSERT INTO [dbo].[FECHAS_CELOS] ([PK_FK_NUMERO_TRAZABLE_VACA], [PK_FECHA]) 
VALUES	(457, '2018-09-12 20:19:11'),
		(457, '2019-07-16 20:19:31');
