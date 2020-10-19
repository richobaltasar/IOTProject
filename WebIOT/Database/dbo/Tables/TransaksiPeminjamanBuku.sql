CREATE TABLE [dbo].[TransaksiPeminjamanBuku] (
    [Id]             BIGINT         IDENTITY (1, 1) NOT NULL,
    [IdBuku]         BIGINT         NULL,
    [SewaDari]       NVARCHAR (MAX) NULL,
    [Sewasampai]     NVARCHAR (MAX) NULL,
    [TotalSewa]      FLOAT (53)     NULL,
    [Status]         BIGINT         NULL,
    [IdUser_Penyewa] BIGINT         NULL,
    [IdTrx]          BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

