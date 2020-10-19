CREATE TABLE [dbo].[LogPengembalianBuku] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [IdPeminjaman]        BIGINT         NULL,
    [IdBook]              BIGINT         NULL,
    [TanggalPengembalian] NVARCHAR (MAX) NULL,
    [UserID]              BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

