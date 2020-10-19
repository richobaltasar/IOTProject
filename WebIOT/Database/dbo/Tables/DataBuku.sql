CREATE TABLE [dbo].[DataBuku] (
    [IdBook]           BIGINT         IDENTITY (1, 1) NOT NULL,
    [JudulBuku]        NVARCHAR (MAX) NOT NULL,
    [Pengarang]        NVARCHAR (MAX) NOT NULL,
    [JenisBuku]        NVARCHAR (MAX) NOT NULL,
    [HargaSewaPerHari] FLOAT (53)     NOT NULL,
    [Img]              NVARCHAR (MAX) NULL,
    [Status]           BIGINT         NULL,
    PRIMARY KEY CLUSTERED ([IdBook] ASC)
);

