IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'ups_InsertLog')
DROP PROCEDURE ups_InsertLog
GO

CREATE PROCEDURE dbo.ups_InsertLog
(
    @pLevel NVARCHAR(50),
    @pLogger NVARCHAR(255),
    @pMessage NVARCHAR(4000)
)
--_____________________________________________________
/*
	Creation Date	:	October 6, 2018
	Author			:	Jose Rodriguez
	Company			:	Belatrix Software
	Description		:	Insert Log in DB
	History			:
	Sample			:
*/
--_____________________________________________________
AS
BEGIN
	SET NOCOUNT ON;
		DECLARE @pDate DATETIME
		SET @pDate = GETUTCDATE()

		INSERT INTO [dbo].[Log] ([Date], [Level], [Logger], [Message])
		VALUES (@pDate, @pLevel, @pLogger, @pMessage)


	SET NOCOUNT OFF;
END