CREATE TABLE [dbo].[LogConfirmation] (
    [IdTrx]           BIGINT        IDENTITY (1, 1) NOT NULL,
    [CreateDate]      NVARCHAR (20) NULL,
    [IdPenyewa]       BIGINT        NULL,
    [Qty]             FLOAT (53)    NULL,
    [TotalSewa]       FLOAT (53)    NULL,
    [StatusConfirm]   BIGINT        NULL,
    [KasirTerimaUang] FLOAT (53)    NULL,
    [UangKembalian]   FLOAT (53)    NULL,
    [IdKasir]         BIGINT        NULL,
    PRIMARY KEY CLUSTERED ([IdTrx] ASC)
);

