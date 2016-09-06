using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public string Name { get; set; }
    }
}