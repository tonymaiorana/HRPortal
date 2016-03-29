using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Data
{
    public interface IPolicyInterFace
    {
        List<Category> GetAllCategories();

        List<Policy> GetAllPolicies();

        List<Policy> GetAllPoliciesForCategory(Category c);

        Policy GetPolicyByID(int ID);

        Category GetCategoryByID(int ID);

        void DeletePolicy(Policy p);

        void AddPolicy(Policy p);

        void EditPolicy(Policy p);

        void DeleteCategory(Category c);

        void AddCategory(Category c);

        void EditCategory(Category c);
    }
}