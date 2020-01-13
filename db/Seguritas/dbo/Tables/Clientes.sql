CREATE TABLE [dbo].[Clientes] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]            NVARCHAR (100) NOT NULL,
    [FechaModificacion] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

