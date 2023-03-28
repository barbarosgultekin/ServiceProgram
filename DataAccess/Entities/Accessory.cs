using Core.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Accessory:BaseEntity
    {

        public Accessory()
        {
            CreatedAt = DateTime.Now;
        }

        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
