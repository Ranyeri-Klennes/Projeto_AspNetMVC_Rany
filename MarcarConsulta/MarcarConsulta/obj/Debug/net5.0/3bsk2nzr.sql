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
VALUES (N'20211119161926_humberto2109292130_rany', N'5.0.4');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pacientes]') AND [c].[name] = N'ExameId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Pacientes] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Pacientes] DROP COLUMN [ExameId];
GO

EXEC sp_rename N'[TiposExames].[PacienteId]', N'ExameId', N'COLUMN';
GO

ALTER TABLE [Exames] ADD [TipoExameId] int NOT NULL DEFAULT 0;
GO

CREATE TABLE [PacienteExame] (
    [PacienteId] int NOT NULL,
    [ExameId] int NOT NULL,
    CONSTRAINT [PK_PacienteExame] PRIMARY KEY ([ExameId], [PacienteId]),
    CONSTRAINT [FK_PacienteExame_Exames_ExameId] FOREIGN KEY ([ExameId]) REFERENCES [Exames] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PacienteExame_Pacientes_PacienteId] FOREIGN KEY ([PacienteId]) REFERENCES [Pacientes] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_PacienteExame_PacienteId] ON [PacienteExame] ([PacienteId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211123095020_Consulta', N'5.0.4');
GO

COMMIT;
GO

