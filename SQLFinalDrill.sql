CREATE PROC dbo.uspQueryLibDb

AS

/* Query 1 */

SELECT 
	Book.Title 'Title',Library_Branch.BranchName 'Branch',
	Book_Copies.No_Of_Copies
	FROM Book
	INNER JOIN Book_Copies ON Book.BookId = Book_Copies.BookId
	INNER JOIN Library_Branch ON Book_Copies.BranchId = Library_Branch.BranchId
	WHERE
	Title = 'The Lost Tribe'
	AND
	BranchName = 'Sharpstown';

/* Query 2 */

SELECT 
	Book.Title 'Title',Library_Branch.BranchName 'Branch',
	Book_Copies.No_Of_Copies
	FROM Book
	INNER JOIN Book_Copies ON Book.BookId = Book_Copies.BookId
	INNER JOIN Library_Branch ON Book_Copies.BranchId = Library_Branch.BranchId
	WHERE
	Title = 'The Lost Tribe';

/* Query 3 */

SELECT 
	Borrower.Name
	FROM   Borrower
	WHERE  NOT EXISTS
	(SELECT *
	FROM   Book_Loans
	WHERE  Book_Loans.CardNo = Borrower.CardNo)
 ;

/* Query 4 */

SELECT
	Book.Title 'Title', Borrower.Name 'Borrower',Borrower.BwrAddress 'Address'
	FROM Book_Loans 
	INNER JOIN Book ON Book.BookId = Book_Loans.BookId
	INNER JOIN Borrower ON Borrower.CardNo = Book_Loans.CardNo
	INNER JOIN Library_Branch ON Book_Loans.BranchId = Library_Branch.BranchId
	WHERE 
	Book_Loans.DueDate = 12-7-17
	AND
	Library_Branch.BranchName = 'Sharpstown'
;

/* Query 5 */

SELECT 
	Library_Branch.BranchName 'Branch Name',
	COUNT (Book_Loans.BranchId) AS 'Number of Loaned Books'
	FROM Book_Loans
	INNER JOIN Library_Branch ON Library_Branch.BranchId = Book_Loans.BranchId
	GROUP BY
	Library_Branch.BranchName
;

/* Query 6 */

SELECT
	Borrower.Name 'Name',Borrower.BwrAddress 'Address',
	COUNT (Book_Loans.CardNo) AS 'Number of Books Checked Out'
	FROM Book_Loans
	INNER JOIN Borrower ON Borrower.CardNo = Book_Loans.CardNo
	GROUP BY
	Borrower.Name,Borrower.BwrAddress
	HAVING COUNT(Book_Loans.CardNo) >5
;

/* Query 7 */

SELECT
	Book.Title 'Title',Book_Copies.No_Of_Copies 'Number of Copies'
	FROM Book
	INNER JOIN Book_Copies ON Book_Copies.BookId = Book.BookId
	INNER JOIN Library_Branch ON Book_Copies.BranchId = Library_Branch.BranchId
	INNER JOIN Book_Authors ON Book_Authors.BookId = Book.BookId
	WHERE
	Book_Authors.AuthorName = 'Stephen King'
	AND
	Library_Branch.BranchName = 'Central';

GO