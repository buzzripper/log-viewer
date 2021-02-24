/*
-- Use master

CREATE LOGIN [LogUser] WITH PASSWORD = 'P@ssword1';
CREATE LOGIN [LogAdmin] WITH PASSWORD = 'P@ssword1';

-- Use Logs

CREATE USER [LogUser] FOR LOGIN [LogUser] WITH DEFAULT_SCHEMA=[dbo];
GRANT CONNECT TO [LogUser];

CREATE ROLE [LogWriter];
GRANT SELECT TO [LogWriter];
GRANT INSERT TO [LogWriter];
ALTER ROLE [LogWriter] ADD MEMBER [LogUser];

CREATE USER [LogAdmin] FOR LOGIN [LogAdmin] WITH DEFAULT_SCHEMA=[dbo];
GRANT CONNECT TO [LogAdmin];

--DROP ROLE [LogAdministrator];
--GRANT SELECT TO [LogAdministrator];
--GRANT INSERT TO [LogAdministrator];
ALTER ROLE [db_owner] ADD MEMBER [LogAdmin];
*/

CREATE TABLE [Logs](
	[TimeStamp] [datetime] NULL,
	[Level] [nvarchar](12) NULL,
	[LevelValue] [int] NULL,
	[AppId] [varchar](100) NULL,
	[SourceContext] [varchar](500) NULL,
	[SourceClass] [varchar](100) NULL,
	[UserName] [varchar](50) NULL,
	[CorrelationId] [varchar](50) NULL,
	[Message] [nvarchar](max) NULL,
	[Exception] [nvarchar](max) NULL,
	[RowId] [uniqueidentifier] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Logs] ADD  CONSTRAINT [DF_Logs_RowId]  DEFAULT (newid()) FOR [RowId]

CREATE INDEX IX_TimeStamp ON Logs (TimeStamp);
CREATE INDEX IX_LevelValue ON Logs (LevelValue);
CREATE INDEX IX_AppId ON Logs (AppId);
GO