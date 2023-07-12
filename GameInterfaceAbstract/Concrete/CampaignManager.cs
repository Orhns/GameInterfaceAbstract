using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.Name + ", discount: %" + campaign.DiscountPercentage + " added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.Name + ", discount: %" + campaign.DiscountPercentage + " deleted.");
        }

        public double GetDiscountPercentage(Campaign campaign)
        {
           return campaign.DiscountPercentage;
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign " + campaign.Name + ", discount: %" + campaign.DiscountPercentage + " updated.");
        }
    }
}
