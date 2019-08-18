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

DELETE FROM [dbo].[MODO_PRENNES]
DELETE FROM [dbo].[RAZA]
DELETE FROM [dbo].[DESARROLLO]

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
VALUES	(1, 'Raza 1'), 
		(2, 'Raza 2'),
		(3, 'Raza 3');
SET IDENTITY_INSERT dbo.[RAZA] OFF

SET IDENTITY_INSERT dbo.[DESARROLLO] ON
INSERT INTO dbo.[DESARROLLO] ([PK_ID_DESARROLLO], [ESTADO])
VALUES	(1, 'Ternera'),
		(2, 'Novilla'),
		(3, 'Vaca');
SET IDENTITY_INSERT dbo.[DESARROLLO] OFF 
