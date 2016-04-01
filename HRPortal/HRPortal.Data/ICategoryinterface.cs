using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;

namespace HRPortal.Data
{
    interface ICategoryinterface
    {
        List<Category> GetAllCategories();

        Category GetCategoryByID(int ID);

        void DeleteCategory(Category c);

        void AddCategory(Category c);

        void EditCategory(Category c);

    }
}
