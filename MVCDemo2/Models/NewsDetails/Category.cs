using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Models.NewsDetails
{
    [Table("Category")]
    public class Category
    {
        public int CategoryId { set; get; }
        public string CategoryName { set; get; }
    }
}
