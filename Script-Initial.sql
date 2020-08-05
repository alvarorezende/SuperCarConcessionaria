IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Cambios] (
    [CambioId] uniqueidentifier NOT NULL,
    [TipoCambio] varchar(200) NOT NULL,
    CONSTRAINT [PK_Cambios] PRIMARY KEY ([CambioId])
);

GO

CREATE TABLE [Combustiveis] (
    [CombustivelId] uniqueidentifier NOT NULL,
    [TipoCombustivel] varchar(200) NOT NULL,
    CONSTRAINT [PK_Combustiveis] PRIMARY KEY ([CombustivelId])
);

GO

CREATE TABLE [Cores] (
    [CorId] uniqueidentifier NOT NULL,
    [NomeCor] varchar(200) NOT NULL,
    CONSTRAINT [PK_Cores] PRIMARY KEY ([CorId])
);

GO

CREATE TABLE [Marcas] (
    [MarcaId] uniqueidentifier NOT NULL,
    [NomeMarca] varchar(200) NOT NULL,
    CONSTRAINT [PK_Marcas] PRIMARY KEY ([MarcaId])
);

GO

CREATE TABLE [Veiculos] (
    [VeiculoId] uniqueidentifier NOT NULL,
    [Placa] varchar(7) NOT NULL,
    [Modelo] varchar(200) NOT NULL,
    [Ano] int NOT NULL,
    [AnoModelo] int NOT NULL,
    [KmRodado] int NOT NULL,
    [QtdPortas] int NOT NULL,
    [ObsVeiculo] varchar(1000) NULL,
    [MarcaId] uniqueidentifier NULL,
    [CambioId] uniqueidentifier NULL,
    [CombustivelId] uniqueidentifier NULL,
    [CorId] uniqueidentifier NULL,
    CONSTRAINT [PK_Veiculos] PRIMARY KEY ([VeiculoId]),
    CONSTRAINT [FK_Veiculos_Cambios_CambioId] FOREIGN KEY ([CambioId]) REFERENCES [Cambios] ([CambioId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Veiculos_Combustiveis_CombustivelId] FOREIGN KEY ([CombustivelId]) REFERENCES [Combustiveis] ([CombustivelId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Veiculos_Cores_CorId] FOREIGN KEY ([CorId]) REFERENCES [Cores] ([CorId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Veiculos_Marcas_MarcaId] FOREIGN KEY ([MarcaId]) REFERENCES [Marcas] ([MarcaId]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Veiculos_CambioId] ON [Veiculos] ([CambioId]);

GO

CREATE INDEX [IX_Veiculos_CombustivelId] ON [Veiculos] ([CombustivelId]);

GO

CREATE INDEX [IX_Veiculos_CorId] ON [Veiculos] ([CorId]);

GO

CREATE INDEX [IX_Veiculos_MarcaId] ON [Veiculos] ([MarcaId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200805133305_Initial', N'2.2.6-servicing-10079');

GO
