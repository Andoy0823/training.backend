CREATE PROCEDURE [dbo].[sp_InsertOrder]
	@customerName NVARCHAR(50),
	@customerEmail NVARCHAR(50),
	@recipientName NVARCHAR(50),
	@recipientEmail NVARCHAR(50),
	@storeName NVARCHAR(50),
	@voucherPrice FLOAT,
	@dedication TEXT = ' '
AS
	INSERT INTO
		[dbo].[Orders] (CustomerName, CustomerEmail, RecipientName, RecipientEmail, StoreName, VoucherPrice, Dedication)
	VALUES
		(@customerName, @customerEmail, @recipientName, @recipientEmail, @storeName, @voucherPrice, @dedication)