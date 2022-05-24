using w10d2.FakeDB;
using w10d2.Models;

namespace w10d2.Services
{
    public class JobsService
    {
        internal List<Job> GetAll()
        {
            return Database.Jobs;
        }

        internal Job GetById(string id)
        {
            Job found = Database.Jobs.Find(job => job.Id == id);
            if(found == null)
            {
                throw new Exception("Could not find job with that id.");
            }
            return found;
        }

        internal Job Create(Job data)
        {
            Database.Jobs.Add(data);
            return data;
        }

        internal Job Edit(Job update)
        {
            Job edited = GetById(update.Id);

            edited.JobTitle = update.JobTitle ?? edited.JobTitle;
            edited.Rate = update.Rate;
            edited.Hours = update.Hours;
            edited.Description = update.Description ?? edited.Description;
            edited.Company = update.Company ?? edited.Company;

            return edited;
        }

        internal Job Remove(string id)
        {
            Job removed = GetById(id);
            if(Database.Jobs.Remove(removed))
            {
                return removed;
            }
            else
            {
                throw new Exception("Unable to remove job.");
            }
        }
    }
}