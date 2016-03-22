using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;

namespace HRPortal.Data
{
    public class MockResumeRepository : IResumeRepository
    {
        private static List<Resume> _resumes = new List<Resume>();

        public MockResumeRepository()
        {
            if (!_resumes.Any())
            {
                _resumes.AddRange(new List<Resume>()
                {
                    new Resume
                    {
                        ResumeID = 1,
                        FirstName = "Goo",
                        LastName = "Frob",
                        DateCreated = DateTime.Today,
                        DateUpdated = DateTime.Today,
                        ApplyingPosition = null,
                        ResumeFile = null
                    },
                    new Resume
                     {
                        ResumeID = 2,
                        FirstName = "Doooo",
                        LastName = "Man",
                        DateCreated = DateTime.Today,
                        DateUpdated = DateTime.Today,
                        ApplyingPosition = null,
                        ResumeFile = null
                    }
                });
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
        }

        public void Delete(int resumeID)
        {
            _resumes.RemoveAll(r => r.ResumeID == resumeID);
        }

        public void Edit(Resume resume)
        {
            Delete(resume.ResumeID);
            _resumes.Add(resume);
        }

        public Resume GetByID(int resumeID)
        {
            return _resumes.FirstOrDefault((r => r.ResumeID == resumeID));
        }
    }
}
