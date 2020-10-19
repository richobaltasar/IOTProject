CREATE TABLE [dbo].[GroupData_MenuAkses] (
    [Id]     INT    IDENTITY (1, 1) NOT NULL,
    [IdRole] BIGINT NULL,
    [IdMenu] BIGINT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

