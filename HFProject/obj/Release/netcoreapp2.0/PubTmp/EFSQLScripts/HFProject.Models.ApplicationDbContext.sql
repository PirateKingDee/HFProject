IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822002527_addCustomer')
BEGIN
    CREATE TABLE [Customers] (
        [CustomerId] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822002527_addCustomer')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822002527_addCustomer', N'2.0.3-rtm-10026');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822004732_addAppointment')
BEGIN
    CREATE TABLE [Appointment] (
        [AppointmentId] int NOT NULL IDENTITY,
        [AppointmentDate] datetime2 NOT NULL,
        [Note] nvarchar(max) NULL,
        [Type] nvarchar(max) NULL,
        [UserId] int NOT NULL,
        CONSTRAINT [PK_Appointment] PRIMARY KEY ([AppointmentId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822004732_addAppointment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822004732_addAppointment', N'2.0.3-rtm-10026');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822005218_addForeignKeyToAppointment')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822005218_addForeignKeyToAppointment', N'2.0.3-rtm-10026');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822005845_addForeignKeyToAppointment2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822005845_addForeignKeyToAppointment2', N'2.0.3-rtm-10026');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822162919_foreignkey')
BEGIN
    EXEC sp_rename N'Appointment.UserId', N'CustomerId', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822162919_foreignkey')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822162919_foreignkey', N'2.0.3-rtm-10026');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822163609_foreignkeyfix1')
BEGIN
    CREATE INDEX [IX_Appointment_CustomerId] ON [Appointment] ([CustomerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822163609_foreignkeyfix1')
BEGIN
    ALTER TABLE [Appointment] ADD CONSTRAINT [FK_Appointment_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822163609_foreignkeyfix1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822163609_foreignkeyfix1', N'2.0.3-rtm-10026');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822164830_addForiegnKey')
BEGIN
    EXEC sp_rename N'Appointment.UserId', N'CustomerId', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822164830_addForiegnKey')
BEGIN
    CREATE INDEX [IX_Appointment_CustomerId] ON [Appointment] ([CustomerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822164830_addForiegnKey')
BEGIN
    ALTER TABLE [Appointment] ADD CONSTRAINT [FK_Appointment_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([CustomerId]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180822164830_addForiegnKey')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180822164830_addForiegnKey', N'2.0.3-rtm-10026');
END;

GO

