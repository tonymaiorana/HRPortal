using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPortal.Data
{
    public class MockPolicyRepo : IPolicyInterFace
    {
        private List<Category> _categories = new List<Category>();
        private List<Policy> _policies = new List<Policy>();

        public MockPolicyRepo()
        {
            if (!_categories.Any())
            {
                _categories.Add(new Category { CategoryID = 1, CategoryTitle = "Dress Code" });
                _categories.Add(new Category { CategoryID = 2, CategoryTitle = "Drug Testing" });
                _categories.Add(new Category { CategoryID = 3, CategoryTitle = "Parking Etiquette" });
            }

            if (!_policies.Any())
            {
                _policies.Add(new Policy(_categories.FirstOrDefault()) { Content = "You must wear pants", Title = "The golden rule", PolicyID = 1 });
                _policies.Add(new Policy(_categories.FirstOrDefault()) { Content = "You must wear pants and shirts", Title = "The golden rule 2.0", PolicyID = 2 });
                _policies.Add(new Policy(_categories.LastOrDefault()) { Content = "You must park inside the lines", Title = "How to park", PolicyID = 3 });
            }
        }

        public List<Category> GetAllCategories()
        {
            return _categories;
        }

        public List<Policy> GetAllPolicies()
        {
            return _policies;
        }

        public List<Policy> GetAllPoliciesForCategory(Category c)
        {
            return _policies.FindAll(p => p.Category.CategoryID == c.CategoryID).ToList();
        }

        public Policy GetPolicyByID(int ID)
        {
            return _policies.FirstOrDefault(p => p.PolicyID == ID);
        }

        public Category GetCategoryByID(int ID)
        {
            return _categories.FirstOrDefault(c => c.CategoryID == ID);
        }

        public void DeletePolicy(Policy p)
        {
            _policies.RemoveAll(l => l.PolicyID == p.PolicyID);
        }

        public void AddPolicy(Policy p)
        {
            if (p.PolicyID < 1)
            {
                var lastOrDefault = _policies.LastOrDefault();
                if (lastOrDefault != null)
                {
                    p.PolicyID = lastOrDefault.PolicyID + 1;
                }
                else
                {
                    p.PolicyID = 1;
                }
            }
            _policies.Add(p);
        }

        public void EditPolicy(Policy p)
        {
            DeletePolicy(p);
            _policies.Add(p);
        }

        public void DeleteCategory(Category c)
        {
            _categories.RemoveAll(l => l.CategoryID == c.CategoryID);
        }

        public void AddCategory(Category c)
        {
            if (c.CategoryID < 1)
            {
                var lastOrDefault = _categories.LastOrDefault();
                if (lastOrDefault != null)
                {
                    c.CategoryID = lastOrDefault.CategoryID + 1;
                }
                else
                {
                    c.CategoryID = 1;
                }
            }
            _categories.Add(c);
        }

        public void EditCategory(Category c)
        {
            DeleteCategory(c);
            _categories.Add(c);
        }
    }
}