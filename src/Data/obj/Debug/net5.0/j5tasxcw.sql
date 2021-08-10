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
    [NomeCompleto] varchar(100) NOT NULL,
    [Tipo] int NOT NULL,
    [Documento] varchar(18) NOT NULL,
    [Telefone] varchar(15) NOT NULL,
    [Genero] int NOT NULL,
    [DataNascimento] datetime NOT NULL,
    [DataCadastro] datetime NOT NULL,
    [Ativo] bit NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Enderecos] (
    [Id] uniqueidentifier NOT NULL,
    [ClienteId] uniqueidentifier NOT NULL,
    [Logradouro] varchar(150) NOT NULL,
    [Numero] varchar(50) NOT NULL,
    [Complemento] varchar(100) NULL,
    [Cep] varchar(10) NOT NULL,
    [Bairro] varchar(50) NOT NULL,
    [Cidade] varchar(100) NOT NULL,
    [Estado] varchar(50) NOT NULL,
    CONSTRAINT [PK_Enderecos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Enderecos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [Eventos] (
    [Id] uniqueidentifier NOT NULL,
    [ClienteId] uniqueidentifier NOT NULL,
    [Titulo] varchar(100) NOT NULL,
    [Descricao] varchar(1000) NOT NULL,
    [Valor] decimal(6,2) NOT NULL,
    [Convidados] int NOT NULL,
    [DataEvento] datetime NOT NULL,
    [DataCadastro] datetime NOT NULL,
    CONSTRAINT [PK_Eventos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Eventos_Clientes_ClienteId] FOREIGN KEY ([ClienteId]) REFERENCES [Clientes] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [EnderecoEventos] (
    [Id] uniqueidentifier NOT NULL,
    [EventoId] uniqueidentifier NOT NULL,
    [Logradouro] varchar(150) NOT NULL,
    [Numero] varchar(50) NOT NULL,
    [Complemento] varchar(100) NULL,
    [Cep] varchar(10) NOT NULL,
    [Bairro] varchar(50) NOT NULL,
    [Cidade] varchar(100) NOT NULL,
    [Estado] varchar(50) NOT NULL,
    CONSTRAINT [PK_EnderecoEventos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EnderecoEventos_Eventos_EventoId] FOREIGN KEY ([EventoId]) REFERENCES [Eventos] ([Id]) ON DELETE NO ACTION
);
GO

CREATE UNIQUE INDEX [IX_EnderecoEventos_EventoId] ON [EnderecoEventos] ([EventoId]);
GO

CREATE UNIQUE INDEX [IX_Enderecos_ClienteId] ON [Enderecos] ([ClienteId]);
GO

CREATE INDEX [IX_Eventos_ClienteId] ON [Eventos] ([ClienteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210809212443_Initial', N'5.0.7');
GO

COMMIT;
GO

