using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public int Miktar { get; set; }
        public string Tip { get; set; }
        public int KiralamaFiyatı { get; set; }
        public string UygunlukDurumu { get; set; } = "Bütün Araçlar Garajda Mevcuttur.";
    }
}
