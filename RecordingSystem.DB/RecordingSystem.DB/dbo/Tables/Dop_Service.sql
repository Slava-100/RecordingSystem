CREATE TABLE [dbo].[Dop_Service] (
    [DoctorId]  INT NULL,
    [ServiceId] INT NULL,
    FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([Id]),
    CONSTRAINT [FK__Doctor_Se__Docto__0D7A0286] FOREIGN KEY ([DoctorId]) REFERENCES [dbo].[Doctor] ([Id])
);

