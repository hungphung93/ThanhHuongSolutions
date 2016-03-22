﻿using System;
using System.Threading.Tasks;
using ThanhHuongSolution.BillingManagement.Domain.Entity;
using ThanhHuongSolution.BillingManagement.Domain.Interface;
using ThanhHuongSolution.BillingManagement.Domain.Model;

namespace ThanhHuongSolution.BillingManagement.Domain.Factory
{
    public class GetModelVisitor : IGetModelVisitor<GetModelVisitor>
    {
        public BaseBillModel Bill;

        public Task<GetModelVisitor> Visit(MDReceivingBill mdBill)
        {
            var bill = new ReceivingBillingInfo()
            {
                Id = mdBill.Id,
                TrackingNumber = mdBill.TrackingNumber,
                Customer = mdBill.Customer,
                TotalAmount = mdBill.TotalAmount,
                BillCreatedDate = mdBill.BillCreatedDate,
                CreatedAt = mdBill.CreatedAt,
                Cart = mdBill.Cart,
                IncurredCost = mdBill.IncurredCost
            };

            Bill = bill;

            return Task.FromResult(this);
        }

        public async Task<GetModelVisitor> Visit(MDBill mdBill)
        {
            var bill = new BillingInfo()
            {
                Id = mdBill.Id,
                TrackingNumber = mdBill.TrackingNumber,
                Customer = mdBill.Customer,
                TotalAmount = mdBill.TotalAmount,
                BillCreatedDate = mdBill.BillCreatedDate,
                CreatedAt = mdBill.CreatedAt,
                Cart = mdBill.Cart
            };

            Bill = bill;

            return await Task.FromResult(this);
        }
    }
}
