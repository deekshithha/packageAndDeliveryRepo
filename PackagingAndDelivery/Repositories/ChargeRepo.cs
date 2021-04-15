using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagingAndDelivery.Repositories
{
    public class ChargeRepo : IRepo
    {
        

        public ChargeRepo()
        {
            
        }

        public double PackagingDeliveryCharge(string item,int count)
        {
            int Pcharge = 0;//Packaging charges
            int Dcharge = 0;//Delivery charges 
            double tcharge = 0;//total charge
            if (item == "Integral")
            {
                Pcharge = count * 100;
                Dcharge = 200;
                tcharge = Pcharge + Dcharge + (50 * count); //50* charges.Count is for Protective sheath
            }
            else if (item == "Accessory")
            {
                Pcharge = count * 50;
                Dcharge = 100;
                tcharge = Pcharge + Dcharge + (50 * count);
            }
            return tcharge;
        }
        
    }
}
