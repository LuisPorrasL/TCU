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

INSERT INTO [dbo].[MODO_PRENNES] ([PK_ID_MODO_PRENNES], [MODO_PRENNES]) 
VALUES	(1, 'No preñada'),
		(2, 'Transferencia de embriones'),
		(3, 'Monto natural'),
		(4, 'IA TD'),
		(5, 'IA')