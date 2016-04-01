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
        List<Policy> GetAllPolicies();

        List<Policy> GetAllPoliciesForCategory(Category c);

        Policy GetPolicyByID(int ID);

        void DeletePolicy(Policy p);

        void AddPolicy(Policy p);

        void EditPolicy(Policy p);
        
    }
}