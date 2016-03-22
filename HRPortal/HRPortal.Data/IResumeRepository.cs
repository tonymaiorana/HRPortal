using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPortal.Models;

namespace HRPortal.Data
{
    public interface IResumeRepository
    {
        List<Resume> GetAllResumes();
        void Add(Resume newResume);
        void Delete(int resumeID);
        void Edit(Resume resume);
        Resume GetByID(int resumeID);
    }
}
