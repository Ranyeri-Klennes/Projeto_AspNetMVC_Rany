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

CREATE TABLE [Exames] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Obs] nvarchar(max) NULL,
    CONSTRAINT [PK_Exames] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Pacientes] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [CPF] int NOT NULL,
    [DataNascimento] datetime2 NOT NULL,
    [Genero] nvarchar(max) NULL,
    [Telefone] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [ExameId] int NOT NULL,
    CONSTRAINT [PK_Pacientes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [TiposExames] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    [PacienteId] int NOT NULL,
    CONSTRAINT [PK_TiposExames] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211119003136_Consulta', N'5.0.4');
GO

GO

