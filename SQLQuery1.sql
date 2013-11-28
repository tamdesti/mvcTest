CREATE TABLE [dbo].[Course] (
    [CourseID] INT           IDENTITY (1, 1) NOT NULL,
    [Title]    NVARCHAR (50) NULL,
    [Credits]  INT           NULL,
    PRIMARY KEY CLUSTERED ([CourseID] ASC)
);

CREATE TABLE [dbo].[Student] (
    [StudentID]      INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [EnrollmentDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([StudentID] ASC)
);

CREATE TABLE [dbo].[Enrollment] (
    [EnrollmentID] INT IDENTITY (1, 1) NOT NULL,
    [Grade]        DECIMAL(3, 2) NULL,
    [CourseID]     INT NOT NULL,
    [StudentID]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([EnrollmentID] ASC),
    CONSTRAINT [FK_dbo.Enrollment_dbo.Course_CourseID] FOREIGN KEY ([CourseID]) 
        REFERENCES [dbo].[Course] ([CourseID]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Enrollment_dbo.Student_StudentID] FOREIGN KEY ([StudentID]) 
        REFERENCES [dbo].[Student] ([StudentID]) ON DELETE CASCADE
);

INSERT INTO Course
(Title, Credits) 
Values ('Economics', 3), ('Literature', 3), ('Chemistry', 4);

INSERT INTO Student
(LastName, FirstName, EnrollmentDate)
VALUES 
('Tibbetts', 'Donnie', '2013-09-01'), 
('Guzman', 'Liza', '2012-01-13'), 
('Catlett', 'Phil', '2011-09-03');

INSERT INTO Enrollment
(Grade, CourseID, StudentID)
VALUES 
(2.00, 1, 1),
(3.50, 1, 2),
(4.00, 2, 3),
(1.80, 2, 1),
(3.20, 3, 1),
(4.00, 3, 2);