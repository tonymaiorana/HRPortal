using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace HRPortal.UI.Models
{
    public class PolicyVM
    {
        public Policy Policy { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public PolicyVM(List<Category> categories)
        {
            Categories = new List<SelectListItem>();
            foreach (Category category in categories)
            {
                SelectListItem categorySelectListItem = new SelectListItem() { Text = category.CategoryTitle, Value = category.CategoryID.ToString() };
                Categories.Add(categorySelectListItem);
            }
        }
    }
}