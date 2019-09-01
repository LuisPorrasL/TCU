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
VALUES	(1, 'Lola', 'Inútil', 2, '2018-1-1', 1, NULL, NULL, 100.2, 3, 1, NULL),
		(2, NULL, 'Útil', 3, '2019-2-1', 2, NULL, NULL, 100.3, 2, 1, NULL),
		(3, 'Lula', 'Medio útil', 2, '2019-1-1', 1, 1, NULL, 99.3, 3, 1, NULL),
		(4, NULL, 'Muerta #1', 3, '2018-1-1', 1, NULL, NULL, NULL, 3, 0, 'Venta'),
		(5, NULL, 'Muerta #2', 3, '2018-5-5', 1, NULL, NULL, NULL, 1, 0, 'Muerte prematura');
