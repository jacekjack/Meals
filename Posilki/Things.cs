using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posilki
{
    public class Things
    {
        public string Name { get; set; }
        public int Kcal { get; set; }
        public int Weight { get; set; }
        public int Carbohydrates { get; set; }
        public int Sugar { get; set; }
        public int Fat { get; set; }
        public int Salt { get; set; }
        public int Protein { get; set; }
        public int Cost { get; set; }

        public Things(string sName, int sKcal, int sWeight, int sCarbohydrates, int sSugar, int sFat, int sSalt, int sProtein, int sCost)
        {
            Name = sName;
            Kcal = sKcal;
            Weight = sWeight;
            Carbohydrates = sCarbohydrates;
            Sugar = sSugar;
            Fat = sFat;
            Salt = sSalt;
            Protein = sProtein;
            Cost = sCost;
        }
    }
    
}
