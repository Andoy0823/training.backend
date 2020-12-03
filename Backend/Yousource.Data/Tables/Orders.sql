CREATE TABLE [dbo].[Orders]
(
	[OrderID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(), 
    [CustomerName] NVARCHAR(50) NOT NULL, 
    [CustomerEmail] NVARCHAR(50) NOT NULL, 
    [RecipientName] NVARCHAR(50) NOT NULL, 
    [RecipientEmail] NVARCHAR(50) NOT NULL, 
    [StoreName] NVARCHAR(50) NOT NULL, 
    [VoucherPrice] FLOAT NOT NULL, 
    [Dedication] TEXT NULL, 
    [OrderDate] DATETIME NOT NULL DEFAULT GETUTCDATE()
)
