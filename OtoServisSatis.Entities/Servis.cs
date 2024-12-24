using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//servis
namespace OtoServisSatis.Entities
{
    public class Servis : IEntity
    {
        public int ID { get; set; }
        public DateTime ServiseGelisTarigi { get; set; }
        public string AracSorunu {  get; set; }
        public decimal ServisUcreti {  get; set; }
        public DateTime ServistenCikisTarihi { get; set; }
        public string? YapilanIslemler {  get; set; }
        public bool GarantiKapsamindaMİ {  get; set; }
        [StringLength(15)]
        public string AracPlaka {  get; set; }
        [StringLength(50)]
        public string Marka {  get; set; }
        [StringLength(50)]
        public string? Model { get; set; }
        [StringLength(50)]
        public string? KasaTipi { get; set; }

        public string? SaseNo {  get; set; }

        public string Notlar {  get; set; }


    }
}
