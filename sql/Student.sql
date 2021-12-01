CREATE TABLE [dbo].[Student] (
    [Id_Student] INT            NOT NULL,
    [FIO]        NVARCHAR (50)  NULL,
    [Id_Gender]  INT            NULL,
    [Id_City]    INT            NULL,
    [Address]    NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id_Student] ASC),
    CONSTRAINT [FK_Student_City] FOREIGN KEY ([Id_City]) REFERENCES [dbo].[City] ([Id_City]),
    CONSTRAINT [FK_Student_Gender] FOREIGN KEY ([Id_Gender]) REFERENCES [dbo].[Gender] ([Id_Gender])
);

