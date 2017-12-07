CREATE PROCEDURE dbo.uspGetPayInfo @FirstName varchar(30) = NULL, @JobTitle varchar(60) = NULL
AS
SELECT 
Person.Person.FirstName, Person.Person.LastName, HumanResources.Employee.JobTitle, 
HumanResources.EmployeePayHistory.Rate 'Pay Rate', 
HumanResources.EmployeePayHistory.PayFrequency 'Per Month'
FROM HumanResources.Employee
INNER JOIN Person.Person ON HumanResources.Employee.BusinessEntityID = Person.Person.BusinessEntityID
INNER JOIN HumanResources.EmployeePayHistory ON HumanResources.Employee.BusinessEntityID = HumanResources.EmployeePayHistory.BusinessEntityID
WHERE FirstName = ISNULL(@FirstName,FirstName)
AND JobTitle LIKE '%' + ISNULL(@JobTitle ,JobTitle) + '%'
GO