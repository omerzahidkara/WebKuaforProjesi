using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntity

    {
        public int ID { get; set; }
        public int MarkaID { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }

        public decimal Fiyat { get; set; }
        [StringLength(50)]
        public string Model { get; set; }
        [StringLength(50)]
        public string KasaTipi { get; set; }

        public int ModelYili { get; set; }

        public bool SatistaMi { get; set; }

        public string Notlar { get; set; }

        public virtual Marka? Marka {get; set; }





        
    }
}
