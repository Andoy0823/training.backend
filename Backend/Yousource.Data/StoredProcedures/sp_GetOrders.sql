CREATE PROCEDURE [dbo].[sp_GetOrders]
AS
	
SELECT * FROM [dbo].[Orders]

ORDER BY OrderDate DESC