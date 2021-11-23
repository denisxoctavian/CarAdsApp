using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAdModel
{
    public class AutoAdList
    {  
        public List<AutoAd> Ads { get; private set; }
        public AutoAdList()
        {
            Ads = new List<AutoAd>();
        }

        public void Add(AutoAd ad)
        {
            if (Ads.Contains(ad))
            {
                throw new Exception("This ad already exists!");
            }

            Ads.Add(ad);
        }

        public void SaveOnDisk()
        {
            Random random = new Random();
            string randomInt = random.Next(1000).ToString();
            var folderParent = ConfigurationManager.AppSettings["FilePath"];
            foreach(var AutoAd in Ads)
            {
                string pathString = Path.Combine(folderParent, "Ad_" + AutoAd.id);
                Directory.CreateDirectory(pathString);
                string fileName = "Ad_" + AutoAd.id + ".json";
                string pathPics = Path.Combine(pathString, "pics");
                Directory.CreateDirectory(pathPics);
                foreach(var photoPath in AutoAd.pics)
                {
                    
                    File.Copy(photoPath, pathPics+"/pics" +randomInt+ Path.GetFileName(photoPath));

                }
                File.WriteAllText(Path.Combine(pathString, fileName), ToString());
            }
        }

        public void LoadFromDisk()
        {
            var folderParent = ConfigurationManager.AppSettings["FilePath"];
            string[] folderChilds = Directory.GetDirectories(folderParent, "*");
            List<AutoAd> temp = new List<AutoAd>();
            foreach (string folderChild in folderChilds)
            {
                var fInfo = new DirectoryInfo(folderChild);
                var content = Path.Combine(folderChild,$"{fInfo.Name}.json");

               temp = JsonConvert.DeserializeObject<List<AutoAd>>(File.ReadAllText(content));
               Ads.AddRange(temp);

            }
           
        }
        public void SortBy(SortType sortField)
        {
            switch (sortField)
            {
                case SortType.LowestPrice:
                    Ads = Ads.OrderBy(ad => ad.price).ToList();
                    break;

                case SortType.HighestPrice:
                    Ads = Ads.OrderByDescending(ad => ad.price).ToList();
                    break;

                case SortType.OldestYear:
                    Ads = Ads.OrderBy(ad => ad.yearOfFabrication).ToList();
                    break;

                case SortType.NewestYear:
                    Ads = Ads.OrderByDescending(ad => ad.yearOfFabrication).ToList();
                    break;
            }
        }

        public List<AutoAd> PriceFilter(double min, double max)
        {
            
            var result =  Ads.Where(x => x.price >= min && x.price <= max).ToList();
            return result;
        }

        public List<AutoAd> YearFilter(int min, int max)
        {
            var result = Ads.Where(x => x.yearOfFabrication >= min && x.yearOfFabrication <= max).ToList();
            return result;
        }

        public List<AutoAd> BrandFilter(string brand)
        {
            var result = Ads.Where(x => x.brand == brand).ToList();
            return result;
        }

        public List<AutoAd> PriceYearBrandFilter(double priceMin, double priceMax, int yearMin, int yearMax, string brand)
        {
            var result = Ads.Where(x => x.price >= priceMin && x.price <= priceMax).ToList();
            result = result.Where(x => x.yearOfFabrication >= yearMin && x.yearOfFabrication <= yearMax).ToList();
            result = result.Where(x => x.brand == brand).ToList();
            return result;
        }

        public List<AutoAd> PriceYearFilter(double priceMin, double priceMax, int yearMin,int yearMax)
        {
            var result = Ads.Where(x => x.price >= priceMin && x.price <= priceMax).ToList();
            result = result.Where(x => x.yearOfFabrication >= yearMin && x.yearOfFabrication <= yearMax).ToList();
            return result;
        }

        public List<AutoAd> PriceBrandFilter(double priceMin, double priceMax, string brand)
        {
            var result = Ads.Where(x => x.price >= priceMin && x.price <= priceMax).ToList();
            result = result.Where(x => x.brand == brand).ToList();
            return result;

        }

        public List<AutoAd> YearBrandFilter(int yearMin, int yearMax, string brand)
        {
            var result = Ads.Where(x => x.brand == brand).ToList();
            result = result.Where(x => x.yearOfFabrication >= yearMin && x.yearOfFabrication <= yearMax).ToList();
            return result;
        }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(Ads);
        }
    }

    }



