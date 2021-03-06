﻿using System;
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
                        Applicant = new Person()
                        {
                            FirstName = "Bobby",
                            LastName = "Bobberson",
                            Address = new Address()
                            {
                                Street = "1800 Ding Dong Ln",
                                City = "Las Vegas",
                                State = "NV",
                                ZipCode = "44455",
                            },
                            Email = "BobbyBobberson@gmail.com",
                            PhoneNumber = "(764) 904 - 4444",
                            Birthday = new DateTime(1988, 08, 25),
                        },
                        Education = Education.Bootcamp,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        ApplyingPosition = new Position()
                        {
                            Title = "Database Engineer"
                        },
                        JobExperience = new List<JobExperience>()
                        {
                            new JobExperience()
                            {
                                Company = "Joes stuff and what not",
                                 StartDate = new DateTime(1997,02,20),
                                 EndDate = new DateTime(1988,06,09),
                                 Address = null,
                                 PreviousManager = "John Boy",
                                 ContactNumber = "4403332222"
                            }

                        },
                        ResumeFile = null
                    },
                    new Resume
                     {
                        ResumeID = 2,
                        Applicant = new Person()
                        {
                            FirstName = "Johnny",
                            LastName = "Walker",
                            Birthday = new DateTime(1987,07,02),
                            Email = null,
                            PhoneNumber = "(764) 777 - 7777"
                        },
                        Education = Education.HighSchool,
                        DateCreated = DateTime.Today,
                        DateUpdated = DateTime.Today,
                        ApplyingPosition = new Position()
                        {
                            Title = "Software Engineer"
                        },
                        JobExperience = new List<JobExperience>()
                        {
                            new JobExperience()
                            {
                                Company = "The Software Guild",
                                 StartDate = new DateTime(1998,03,31),
                                 EndDate = new DateTime(2001,08,09),
                                 Address = null,
                                 PreviousManager = "John Boy",
                                 ContactNumber = "2203302214"
                            }

                        },
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
