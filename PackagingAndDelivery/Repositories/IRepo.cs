using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery.Repositories
{
    public interface IRepo
    {
        public double PackagingDeliveryCharge(string item,int count);
    }
}
