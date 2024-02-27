﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeCatBusinessObject.BusinessObject;

namespace TheCoffeeCatRepository.IRepository
{
    public interface ICustomerPackageRepo
    {

        public bool ChangeStatus(CustomerPackage customerPackage);


        public List<CustomerPackage> GetCustomerPackages();
        public void AddNew(CustomerPackage customerPackage);


        public CustomerPackage GetCPById(Guid id);

        public void UpdateCP(CustomerPackage customerPackage);

        public IQueryable<CustomerPackage> SearchCP(string name);
    }
}
