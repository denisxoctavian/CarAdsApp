using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdModel
{
    public class AutoAd
    {
        public int id { get; set; }
        public string AdType { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public int yearOfFabrication { get; set; }
        public string fuelType { get; set; }
        public string description { get; set; }
        public List<string> pics { get; set; }


        public override string ToString()
        {
            return $"{id};{AdType};{brand};{model};{price};{yearOfFabrication};{fuelType};{description};{pics}";
        }

        public override bool Equals(object obj)
        {
            if (!(obj is AutoAd))
            {
                return false;
            }

            AutoAd ad = obj as AutoAd;

            return ad.id == id &&
                   ad.AdType == AdType &&
                   ad.brand == brand &&
                   ad.model == model &&
                   ad.yearOfFabrication == yearOfFabrication &&
                   ad.price == price &&
                   ad.fuelType == fuelType &&
                   ad.description == ad.description&&
                   ad.pics == ad.pics;
        }

      




    }
}
