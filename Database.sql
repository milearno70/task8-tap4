
IF DB_ID('LibraryDB') IS NULL CREATE DATABASE LibraryDB;
GO
USE LibraryDB;
GO

IF OBJECT_ID('Loans')   IS NOT NULL DROP TABLE Loans;
IF OBJECT_ID('Books')   IS NOT NULL DROP TABLE Books;
IF OBJECT_ID('Members') IS NOT NULL DROP TABLE Members;
IF OBJECT_ID('Authors') IS NOT NULL DROP TABLE Authors;
GO

CREATE TABLE Authors (
    Id       INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL
);

CREATE TABLE Members (
    Id       INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL
);

CREATE TABLE Books (
    Id          INT IDENTITY(1,1) PRIMARY KEY,
    Title       NVARCHAR(150) NOT NULL,
    AuthorId    INT NOT NULL,
    PublishYear INT NOT NULL,
    CONSTRAINT FK_Books_Authors FOREIGN KEY (AuthorId) REFERENCES Authors(Id)
);

CREATE TABLE Loans (
    Id         INT IDENTITY(1,1) PRIMARY KEY,
    BookId     INT NOT NULL,
    MemberId   INT NOT NULL,
    LoanDate   DATETIME NOT NULL DEFAULT GETDATE(),
    ReturnDate DATETIME NULL,
    CONSTRAINT FK_Loans_Books   FOREIGN KEY (BookId)   REFERENCES Books(Id),
    CONSTRAINT FK_Loans_Members FOREIGN KEY (MemberId) REFERENCES Members(Id)
);
GO

INSERT INTO Authors (FullName) VALUES
 (N'Nizami Gəncəvi'), (N'Cəlil Məmmədquluzadə'), (N'Çingiz Abdullayev');

INSERT INTO Members (FullName) VALUES
 (N'Fatimə Movsumova'), (N'Aydan Məmmədli'), (N'Xanım Məmmədova');

INSERT INTO Books (Title, AuthorId, PublishYear) VALUES
 (N'Xəmsə', 1, 1200),
 (N'Ölülər', 2, 1909),
 (N'Dəli Kür', 3, 1990);

INSERT INTO Loans (BookId, MemberId, LoanDate, ReturnDate) VALUES
 (1, 1, DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -3, GETDATE())),  
 (2, 2, DATEADD(DAY, -2,  GETDATE()), NULL);                        
GO
