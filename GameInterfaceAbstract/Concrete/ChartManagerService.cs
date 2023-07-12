using GameInterfaceAbstract.Abstract;
using GameInterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterfaceAbstract.Concrete
{
    internal class ChartManagerService : IChartService
    {
        /*CampaignManager _campaignManager;

        public ChartManagerService(CampaignManager campaignManager)
        {
            _campaignManager = campaignManager;
        }*/

        public void AddToChart(Member member, List<GameProduct> gameProducts)
        {
            double priceCounter = 0;
            for (int i = 0; i < gameProducts.Count; i++)
            {
                Console.WriteLine(gameProducts[i].Name + ", price : " + gameProducts[i].Price);
                priceCounter += gameProducts[i].Price;
            }
            Console.WriteLine("Games added to chart of " + member.FirstName);
            Console.WriteLine("Total price is :" + priceCounter);
        }
        public void AddToChart(Member member, List<GameProduct> gameProducts, Campaign campaign)
        {
            Console.WriteLine("Special Discount by %" + campaign.DiscountPercentage);
            double priceCounter = 0;
            for (int i = 0; i < gameProducts.Count; i++)
            {
                double price = ((gameProducts[i].Price)/100)*(100-campaign.DiscountPercentage);
                Console.WriteLine(gameProducts[i].Name + ", price : " + price);
                priceCounter += price;
            }
            Console.WriteLine("Games added to chart of " + member.FirstName);
            Console.WriteLine("Total price with %" + campaign.DiscountPercentage + " discount is :" + priceCounter);
        }

        public void RemoveFromChart(Member member, List<GameProduct> gameProducts)
        {
            for (int i = 0; i < gameProducts.Count; i++)
            {
                Console.WriteLine(gameProducts[i].Name + ", price : " + gameProducts[i].Price);
            }
            Console.WriteLine("Removed from chart of " + member.FirstName);
        }
    }
}
