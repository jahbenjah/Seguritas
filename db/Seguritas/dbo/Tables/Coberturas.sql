CREATE TABLE [dbo].[Coberturas] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Descripcion]       NVARCHAR (100) NOT NULL,
    [FechaModificacion] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

