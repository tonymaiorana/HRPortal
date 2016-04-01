using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Models
{
    public class Policy
    {
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int PolicyID { get; set; }

        public Policy()
        {
            CategoryID = 0;
        }

        public Policy(Category c)
        {
            Category = c;
            CategoryID = c.CategoryID;
        }
    }
}