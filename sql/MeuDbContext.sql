IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clientes] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(50) NOT NULL,
    [Sobrenome] varchar(100) NOT NULL,
    [Documento] varchar(14) NOT NULL,
    [Telefone] varchar(12) NOT NULL,
    [Genero] int NOT NULL,
    [DataNascimento] datetime NOT NULL,
    [DataCadastro] datetime NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Eventos] (
    [Id] uniqueidentifier NOT NULL,
    [ClienteId] uniqueidentifier NOT NULL,
    [Nome] varchar(100) NOT NULL,
    [Descricao] varchar(1000) NOT NULL,
    [DataEvento] datetime NOT NULL,
    [DataCadastro] datetime NOT NULL,
    CONSTRAINT [PK_Eventos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Eventos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Eventos_ClienteId] ON [Eventos] ([ClienteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210727010927_Initial', N'5.0.8');
GO

COMMIT;
GO

