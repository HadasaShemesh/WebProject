create database StudioSport;

CREATE TABLE [dbo].[Courses] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [IdTeacher] NVARCHAR (9) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Customers] (
    [CustomerId]       NVARCHAR (9)  NOT NULL,
    [Password]         NVARCHAR (5)  NOT NULL,
    [Age]              INT           NULL,
    [Pharm]            NVARCHAR (50) NULL,
    [GivePrescription] BIT           NULL,
    [NormalSport]      INT           NULL,
    [SpecialSport]     INT           NULL,
    [Date]             DATETIME      NULL,
    [AmountOfLesson]   INT           NULL,
    [DoRegular]        BIT           NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED ([CustomerId] ASC),
    CONSTRAINT [FK_Customers_ToTherapeuticSports] FOREIGN KEY ([SpecialSport]) REFERENCES [dbo].[TherapeuticSports] ([IdCourseT]),
    CONSTRAINT [FK_Customers_ToPerson] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Person] ([Id])
);

CREATE TABLE [dbo].[Manager] (
    [ManagerId] NVARCHAR (9) NOT NULL,
    [Password]  NVARCHAR (9) NOT NULL,
    PRIMARY KEY CLUSTERED ([ManagerId] ASC),
    CONSTRAINT [FK_Manager_ToPerson] FOREIGN KEY ([ManagerId]) REFERENCES [dbo].[Person] ([Id])
);

CREATE TABLE [dbo].[NormalSport] (
    [IdCourseN]    INT           NOT NULL,
    [NameOfCourse] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCourseN] ASC),
    CONSTRAINT [FK_NormalSport_ToCourse] FOREIGN KEY ([IdCourseN]) REFERENCES [dbo].[Courses] ([Id])
);

CREATE TABLE [dbo].[Person] (
    [Id]        NVARCHAR (9)  NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    [Addres]    NVARCHAR (50) NOT NULL,
    [Phone]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Teachers] (
    [IdTeacher]             NVARCHAR (9) NOT NULL,
    [password]              NVARCHAR (7) NOT NULL,
    [NormalSport]           INT          NULL,
    [SpecialSport]          INT          NULL,
    [AmountOfLessonTeacher] INT          NULL,
    PRIMARY KEY CLUSTERED ([IdTeacher] ASC),
    CONSTRAINT [FK_Teachers_ToNormalSport] FOREIGN KEY ([NormalSport]) REFERENCES [dbo].[NormalSport] ([IdCourseN]),
    CONSTRAINT [FK_Teachers_ToPerson] FOREIGN KEY ([IdTeacher]) REFERENCES [dbo].[Person] ([Id])
);

CREATE TABLE [dbo].[TherapeuticSports] (
    [IdCourseT]        INT            NOT NULL,
    [ThereIsReference] BIT            NOT NULL,
    [TypeOfDisability] NVARCHAR (50)  NOT NULL,
    [AreaOfDisability] NVARCHAR (50)  NOT NULL,
    [HowPrescription]  INT            NULL,
    [ThereIsImprove]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([IdCourseT] ASC),
    CONSTRAINT [FK_TherapeuticSports_ToCourses] FOREIGN KEY ([IdCourseT]) REFERENCES [dbo].[Courses] ([Id])
);
