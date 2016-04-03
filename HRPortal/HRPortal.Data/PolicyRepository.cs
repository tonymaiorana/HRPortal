using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using HRPortal.Models;

namespace HRPortal.Data
{
    public class PolicyRepository :IPolicyInterFace
    {
       List<Policy> policies = new List<Policy>(); 
       
        public PolicyRepository()
        {
            LoadPolicies();
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
            //call save
            WriteToFile();
        }

        public void AddPolicy(Policy p)
        {
            var nextID = GetAllPolicies().Max(m => m.PolicyID) + 1;
            p.PolicyID = nextID;
            policies.Add(p);
            //call save
            WriteToFile();
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
            //call save
            WriteToFile();

        }

        //load
        public void LoadPolicies()
        {
            policies = new List<Policy>();
            var fileName = System.Web.HttpContext.Current.Server.MapPath(WebConfigurationManager.AppSettings.Get("FileName"));
            using (var sr = new StreamReader(fileName))
            {
                var line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    var filds = line.Split(',');
                
                    Policy policy = new Policy();

                    policy.PolicyID = int.Parse(filds[0]);
                    policy.CategoryID = int.Parse(filds[1]);
                    policy.Title = filds[2];
                    policy.Content = filds[3];

                    policies.Add(policy);
                }
                sr.Close();
            }
        }
      
        //save
        public void WriteToFile()
        {
            var fileName = System.Web.HttpContext.Current.Server.MapPath(WebConfigurationManager.AppSettings.Get("FileName"));
            using (var tw = new StreamWriter(fileName))
            {
                foreach (Policy policy in policies)
                {
                    tw.WriteLine(
                        policy.PolicyID + "," +
                        policy.CategoryID + "," +
                        policy.Title + "," +
                        policy.Content
                        );
                }
                tw.Close();
            }
        }
    }
}
