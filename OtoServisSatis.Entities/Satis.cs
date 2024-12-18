using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Satis : IEntity
    {
        public int ID { get; set; }
        public int AracID { get; set; }
        public int MusteriID { get; set; }
        public decimal SatisFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
        public virtual Arac Arac { get; set; }
        public virtual Musteri Musteri { get; set; }
         
    }
}
