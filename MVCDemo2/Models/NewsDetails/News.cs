using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Models.NewsDetails
{
    [Table("News")]
    public class News
    {
        public int NewsId { set; get; }
        public string Description { get; set; }
        public int CategoryId { set; get; }
        public int RegionId { set; get; }
        public DateTime CreateTime { set; get; }
        public DateTime? PublishDate { set; get; }

    }
}
