CREATE TABLE [dbo].[GroupData] (
    [IdRole]    BIGINT         IDENTITY (1, 1) NOT NULL,
    [NamaGroup] NVARCHAR (MAX) NULL,
    [Status]    BIGINT         NULL,
    [Desc]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([IdRole] ASC)
);

