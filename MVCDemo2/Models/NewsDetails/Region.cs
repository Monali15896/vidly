using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Models.NewsDetails
{
    [Table("Region")]
    public class Region
    {
        public int RegionId { set; get; }
        public string RegionName { set; get; }
    }
}
