using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;

namespace HRPortal.Data
{
    public class PolicyRepository :IPolicyInterFace
    {
       List<Policy> policies = new List<Policy>(); 
       
        public PolicyRepository()
        {

        }
       
        public List<Policy> GetAllPolicies()
        {
            return policies;
        }

        public List<Policy> GetAllPoliciesForCategory(Category c)
        {

            //call the method get category from category repo??
            return GetAllPolicies().Where(p => p.CategoryID == c.CategoryID).ToList();

        }

        public Policy GetPolicyByID(int ID)
        {
            return GetAllPolicies().Where(p => p.PolicyID == ID).FirstOrDefault();
          

        }

        public void DeletePolicy(Policy p)
        {
            // GetPolicyByID(p.PolicyID).;
            policies.Remove(policies.FirstOrDefault(m=>m.PolicyID==p.PolicyID));
        }

        public void AddPolicy(Policy p)
        {
            var nextID = GetAllPolicies().Max(m => m.PolicyID) + 1;
            p.PolicyID = nextID;
            policies.Add(p);
        }

        public void EditPolicy(Policy p)
        {
            for (int i = 0; i < policies.Count; i++)
            {
                if (p.PolicyID == policies[i].PolicyID)
                {
                    policies[i] = p;
                    break;
                }
            }

        }
        //lode 
        //save
    }
}
