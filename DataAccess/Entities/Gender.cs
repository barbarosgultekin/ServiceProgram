using Core.Signatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Gender:BaseEntity
    {
        public Gender()
        {
            CreatedAt = DateTime.Now;
        }

        public string Description { get; set; }      

    }
}
