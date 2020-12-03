﻿// <auto-generated/>

namespace Yousource.Services.Order.Data
{
    using System.Data;
    using System.Data.SqlClient;
    using Yousource.Services.Order.Data.Entities;

    public class OrderSqlCommandFactory : IOrderSqlCommandFactory
    {
        public SqlCommand CreateGetOrdersCommand()
        {
            var result = new SqlCommand("dbo.sp_GetOrders")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            return result;
        }

        public SqlCommand CreateInsertOrderCommand(OrderEntity order)
        {
            var result = new SqlCommand("[dbo].[sp_InsertOrder]")
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = 60
            };

            result.Parameters.AddWithValue("@customerName", order.CustomerName);
            result.Parameters.AddWithValue("@customerEmail", order.CustomerEmail);
            result.Parameters.AddWithValue("@recipientName", order.RecipientName);
            result.Parameters.AddWithValue("@recipientEmail", order.RecipientEmail);
            result.Parameters.AddWithValue("@storeName", order.StoreName);
            result.Parameters.AddWithValue("@voucherPrice", order.VoucherPrice);
            result.Parameters.AddWithValue("@dedication", order.Dedication);

            //// Add all fields as parameters

            return result;
        }
    }
}
