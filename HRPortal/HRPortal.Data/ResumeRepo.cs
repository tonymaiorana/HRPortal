using HRPortal.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace HRPortal.Data
{
    public class ResumeRepo : IResumeRepository
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(List<Resume>));
        private List<Resume> _resumes = new List<Resume>();
        private bool shouldSave = false;

        public ResumeRepo()
        {
            ReadFromXMLFile();
        }

        ~ResumeRepo()
        {
            if (shouldSave)
            {
                SaveToXMLFile();
            }
        }

        public List<Resume> GetAllResumes()
        {
            return _resumes;
        }

        public void Add(Resume newResume)
        {
            newResume.ResumeID = (_resumes.Any()) ? _resumes.Max(r => r.ResumeID) + 1 : 1;
            _resumes.Add(newResume);
            shouldSave = true;
        }

        public void Delete(int resumeID)
        {
            _resumes.RemoveAll(r => r.ResumeID == resumeID);
            shouldSave = true;
        }

        public void Edit(Resume resume)
        {
            Delete(resume.ResumeID);
            _resumes.Add(resume);
            shouldSave = true;
        }

        public Resume GetByID(int resumeID)
        {
            return _resumes.FirstOrDefault((r => r.ResumeID == resumeID));
        }

        private void SaveToXMLFile()
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\Apprentice\Dropbox\Akron\_Repos\hrportaltonytjelle\HRPortal\HRPortal.UI\DataFiles\Resumes.xml"))
            {
                serializer.Serialize(file, _resumes);
            }
        }

        private void ReadFromXMLFile()
        {
            if (File.Exists(@"C:\Users\Apprentice\Dropbox\Akron\_Repos\hrportaltonytjelle\HRPortal\HRPortal.UI\DataFiles\Resumes.xml"))
            {
                using (StreamReader file = new StreamReader(@"C:\Users\Apprentice\Dropbox\Akron\_Repos\hrportaltonytjelle\HRPortal\HRPortal.UI\DataFiles\Resumes.xml"))
                {
                    try
                    {
                        _resumes = (List<Resume>)serializer.Deserialize(file);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error deserializing");
                    }
                }
            }
            else
            {
                _resumes = new List<Resume>();
            }
        }
    }
}