CREATE DATABASE LibraryManagementSystem;

CREATE TABLE Publisher (
	Name VARCHAR(50) PRIMARY KEY NOT NULL,
	PubAddress VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) NOT NULL
);

CREATE TABLE Book (
	BookId INT PRIMARY KEY NOT NULL IDENTITY (100,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) NOT NULL CONSTRAINT fk_PublisherName FOREIGN KEY REFERENCES Publisher(Name) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE Book_Authors (
	BookId INT NOT NULL CONSTRAINT fk_BookId FOREIGN KEY REFERENCES Book(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	AuthorName VARCHAR(50) NOT NULL
);

CREATE TABLE Library_Branch (
	BranchId INT PRIMARY KEY NOT NULL IDENTITY (5000,10),
	BranchName VARCHAR(50) NOT NULL,
	BranchAddress VARCHAR(50) NOT NULL
);

CREATE TABLE Borrower (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	Name VARCHAR(50) NOT NULL,
	BwrAddress VARCHAR(50) NOT NULL,
	Phone VARCHAR(50) NOT NULL
);

CREATE TABLE Book_Loans (
	BookId INT NOT NULL CONSTRAINT fk_LoanBookId FOREIGN KEY REFERENCES Book(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchId INT NOT NULL CONSTRAINT fk_LoanBranchId FOREIGN KEY REFERENCES Library_Branch(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_LoanCardNo FOREIGN KEY REFERENCES Borrower(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut VARCHAR(50) NOT NULL,
	DueDate VARCHAR(50) NOT NULL
);

CREATE TABLE Book_Copies (
	BookId INT NOT NULL CONSTRAINT fk_CopyBookId FOREIGN KEY REFERENCES Book(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchId INT NOT NULL CONSTRAINT fk_CopyBranchId FOREIGN KEY REFERENCES Library_Branch(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	No_Of_Copies INT NOT NULL
);

INSERT INTO Book
	(Title,PublisherName)
	VALUES
	('Where the Red Fern Grows','Randhouse'),
	('Sounder','Randhouse'),
	('Old Yeller','Dominion'),
	('After Dark','Beetlejuice'),
	('Kafka on the Shore','Dominion'),
	('Through the Woods','Randhouse'),
	('Norwegian Wood','Delta'),
	('Sputnik Sweetheart','Randhouse'),
	('The Elephant Vanishes','Dominion'),
	('The Lost Tribe','Randhouse'),
	('Interview With the Vampire','Beetlejuice'),
	('The Shining','Delta'),
	('Beloved', 'Dominion'),
	('The Grapes of Wrath','Randhouse'),
	('The Sound and the Fury','Dominion'),
	('Gone with the Wind','Beetlejuice'),
	('Green Eggs and Ham','Delta'),
	('A Clockwork Orange','Dominion'),
	('The Little Prince','Delta'),
	('The Color Purple','Delta')
;

INSERT INTO Publisher
	(Name,PubAddress,Phone)
	VALUES
	('Randhouse','836 Drury Lane','384-593-0293'),
	('Dominion','45 Farce Way','833-945-9384'),
	('Beetlejuice','3 Times Ave','754-444-8374'),
	('Delta','9845 Main Street','438-968-5027')
;

INSERT INTO Book_Authors
	(BookId,AuthorName)
	VALUES
	(101,'Wilson Rawls'),
	(102,'William H. Armstrong'),
	(103,'Fred Gipson'),
	(104,'Haruki Murakami'),
	(105,'Haruki Murakami'),
	(106,'Emily Carroll'),
	(107,'Haruki Murakami'),
	(108,'Haruki Murakami'),
	(109,'Haruki Murakami'),
	(110,'Mark Lee'),
	(111,'Anne Rice'),
	(112,'Stephen King'),
	(113,'Toni Morrison'),
	(114,'John Steinbeck'),
	(115,'William Faulkner'),
	(116,'Margaret Mitchell'),
	(117,'Dr. Seuss'),
	(118,'Anthony Burgess'),
	(119,'Antoine de Saint-Exupery'),
	(120,'Alice Walker')
;

INSERT INTO Library_Branch
	(BranchName,BranchAddress)
	VALUES
	('Sharpstown','4 Elm Way'),
	('Central','22nd Dearborn St'),
	('Redwood','1827 Main St'),
	('Valley','876 Evergreen Ave')
;

INSERT INTO Book_Copies
	(BookId,BranchId,No_Of_Copies)
	VALUES
	(101,5000,2),
	(102,5000,5),
	(103,5000,2),
	(104,5000,6),
	(105,5000,3),
	(106,5000,2),
	(107,5000,7),
	(108,5000,3),
	(109,5000,4),
	(110,5000,7),
	(111,5010,2),
	(112,5010,2),
	(113,5010,4),
	(114,5010,5),
	(115,5010,6),
	(116,5010,3),
	(117,5010,2),
	(118,5010,6),
	(119,5010,8),
	(120,5010,2),
	(102,5020,3),
	(104,5020,6),
	(106,5020,7),
	(108,5020,3),
	(110,5020,4),
	(112,5020,5),
	(114,5020,7),
	(116,5020,2),
	(118,5020,2),
	(120,5020,5),
	(101,5030,3),
	(103,5030,2),
	(105,5030,5),
	(107,5030,2),
	(109,5030,6),
	(111,5030,3),
	(113,5030,4),
	(115,5030,2),
	(117,5030,3),
	(119,5030,2)
;

INSERT INTO Borrower
	(Name,BwrAddress,Phone)
	VALUES
	('Abigail Brown','123 Cherry St','837-394-0394'),
	('Courtney Dunn','25 1st Ave','968-039-6273'),
	('Edward Falk','228 1st St','964-039-7594'),
	('Gerry Hyde','754 Main St','653-234-8394'),
	('Ian Jacobs','8765 Bell Ln','758-234-8576'),
	('Kevin Lehman','11 20th St','756-485-4837'),
	('Mark Naidas','9384 Main St','657-475-3527'),
	('Olivia Park','900 1st St','643-375-6857'),
	('Quinn Reed','784 Silver St','733-475-8473')
;

INSERT INTO Book_Loans
	(BookId,BranchId,CardNo,DateOut,DueDate)
	VALUES
	(104,5020,1,10-10-17,10-31-17),
	(112,5010,1,12-7-17,1-1-18),
	(107,5000,1,10-10-17,10-31-17),
	(111,5010,1,10-10-17,12-7-17),
	(103,5030,1,10-10-17,12-8-17),
	(106,5000,1,10-10-17,10-31-17),
	(116,5020,1,12-7-17,1-1-18),
	(117,5030,1,10-10-17,10-31-17),
	(101,5000,2,10-10-17,12-7-17),
	(102,5000,2,10-10-17,10-31-17),
	(105,5030,2,10-10-17,10-31-17),
	(106,5010,2,10-10-17,10-31-17),
	(118,5020,2,12-7-17,1-1-18),
	(119,5010,2,10-10-17,12-7-17),
	(111,5030,3,10-10-17,10-31-17),
	(112,5020,3,10-10-17,10-31-17),
	(105,5000,3,10-10-17,12-8-17),
	(109,5000,3,10-10-17,10-31-17),
	(103,5000,3,10-10-17,10-31-17),
	(114,5020,3,10-10-17,10-31-17),
	(108,5020,4,10-10-17,10-31-17),
	(110,5000,4,10-10-17,10-31-17),
	(113,5030,4,10-10-17,12-7-17),
	(119,5010,4,10-10-17,10-31-17),
	(101,5000,4,10-10-17,10-31-17),
	(102,5020,4,10-10-17,12-8-17),
	(120,5020,4,10-10-17,10-31-17),
	(116,5010,4,10-10-17,10-31-17),
	(104,5020,5,10-10-17,10-31-17),
	(105,5000,5,10-10-17,10-31-17),
	(106,5000,5,10-10-17,12-7-17),
	(107,5030,5,10-10-17,10-31-17),
	(108,5020,5,10-10-17,10-31-17),
	(109,5000,5,10-10-17,10-31-17),
	(110,5000,6,10-10-17,10-31-17),
	(111,5010,6,10-10-17,10-31-17),
	(112,5020,6,10-10-17,12-7-17),
	(113,5030,6,10-10-17,10-31-17),
	(114,5020,6,10-10-17,10-31-17),
	(115,5030,7,10-10-17,10-31-17),
	(116,5010,7,10-10-17,10-31-17),
	(117,5030,7,10-10-17,10-31-17),
	(118,5020,7,10-10-17,10-31-17),
	(119,5010,7,10-10-17,12-7-17),
	(120,5020,7,10-10-17,10-31-17),
	(102,5000,7,10-10-17,10-31-17),
	(104,5000,7,10-10-17,10-31-17),
	(112,5010,7,10-10-17,10-31-17),
	(118,5020,8,10-10-17,12-7-17),
	(103,5030,8,10-10-17,10-31-17)
;