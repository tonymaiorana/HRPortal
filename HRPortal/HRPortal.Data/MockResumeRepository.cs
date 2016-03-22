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
        public List<Resume> GetAllResumes()
        {
            throw new NotImplementedException();
        }

        public void Add(Resume newResume)
        {
            throw new NotImplementedException();
        }

        public void Delete(int resumeID)
        {
            throw new NotImplementedException();
        }

        public void Edit(Resume resume)
        {
            throw new NotImplementedException();
        }

        public Resume GetByID(int resumeID)
        {
            throw new NotImplementedException();
        }
    }
}
