CREATE TABLE [dbo].[ClientePlanes] (
    [ClienteId] INT NOT NULL,
    [PlanId] INT NOT NULL,

	CONSTRAINT [PK_ClientesPlanes] PRIMARY KEY CLUSTERED ([ClienteId] ASC, [PlanId] ASC),
    CONSTRAINT [FK_ClientesPlanes_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_ClientesPlanes_Planes_PlanId] FOREIGN KEY ([PlanId]) REFERENCES [dbo].[Planes] ([Id]) ON DELETE CASCADE,
);
