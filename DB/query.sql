Use Sandbox
Go

Create Schema tests
Go

Create Table tests.FileProcessTest
(
	FileName varchar(255) Null,
	ExpectedValue [bit] Not Null,
	CausesException [bit] Not Null
)
Go

Insert into tests.FileProcessTest
Values ('C:\index.html' , 1 , 0)

Insert into tests.FileProcessTest
Values ('C:\BadFile.bad' , 0 , 0)

Insert into tests.FileProcessTest
Values (null , 0 , 1)