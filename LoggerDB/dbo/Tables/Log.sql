--_____________________________________________________
/*
	Creation Date	:	October 6, 2018
	Author			:	Jose Rodriguez
	Description		:	Creation of Log Table
*/
--_____________________________________________________

IF OBJECT_ID('dbo.Log', 'U') IS NOT NULL
DROP TABLE [dbo].[Log];
GO

CREATE TABLE [dbo].[Log] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Date]      DATETIME       NOT NULL,    
    [Level]     VARCHAR (50)   NOT NULL,
    [Logger]    VARCHAR (255)  NOT NULL,
    [Message]   VARCHAR (4000) NOT NULL,
    
);

