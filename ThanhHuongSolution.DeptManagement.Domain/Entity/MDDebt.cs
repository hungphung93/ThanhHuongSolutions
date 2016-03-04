﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanhHuongSolution.BillingManagement.Domain.Entity;
using ThanhHuongSolution.DeptManagement.Domain.Factory;

namespace ThanhHuongSolution.DeptManagement.Domain.Entity
{
    public class MDDebt : MDBaseDebt
    {
        public override async Task<T> Visit<T>(IGetModelVisitor<T> visitor)
        {
            return await visitor.Visit(this);
        }
    }
}
