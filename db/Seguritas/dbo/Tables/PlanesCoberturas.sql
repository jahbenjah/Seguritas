CREATE TABLE [dbo].[PlanesCoberturas] 
(
    [PlanId]    INT NOT NULL,
    [CoberturaId] INT NOT NULL,
    CONSTRAINT [PK_PlanesCoberturas] PRIMARY KEY CLUSTERED ([PlanId] ASC, [CoberturaId] ASC),
    CONSTRAINT [FK_PlanesCoberturas_Coberturas_CoberturaId] FOREIGN KEY ([CoberturaId]) REFERENCES [dbo].[Coberturas] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PlanesCoberturas_Planes_PlanId] FOREIGN KEY ([PlanId]) REFERENCES [dbo].[Planes] ([Id]) ON DELETE CASCADE
);