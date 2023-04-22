CREATE TABLE [dbo].[Table]
(
	[Key] NUMERIC IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Customer_Name] VARCHAR(50) NULL, 
    [Phone_No] NUMERIC NULL, 
    [Customer_Business_Name] VARCHAR(50) NULL, 
    [Adress] VARCHAR(50) NULL, 
    [Vat_No] VARCHAR(50) NULL, 
    [Tax] VARCHAR(50) NULL
)
