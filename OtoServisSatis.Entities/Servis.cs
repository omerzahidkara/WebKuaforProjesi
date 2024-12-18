using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Servis : IEntity
    {
        public int ID { get; set; }
        public DateTime ServiseGelisTarigi { get; set; }
        public string AracSorunu {  get; set; }
        public decimal ServisUcreti {  get; set; }
        public DateTime ServistenCikisTarihi { get; set; }
        public string YapilanIslemler {  get; set; }
        public bool GarantiKapsamindaMİ {  get; set; }
        public string AracPlaka {  get; set; }
        public string Marka {  get; set; }
        public string Model { get; set; }
        public string KasaTipi { get; set; }

        public string SaseNo {  get; set; }

        public string Notlar {  get; set; }


    }
}
