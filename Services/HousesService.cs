using w10d2.FakeDB;
using w10d2.Models;

namespace w10d2.Services
{
    public class HousesService
    {
        internal List<House> GetAll()
        {
            return Database.Houses;
        }

        internal House GetById(string id)
        {
            House found = Database.Houses.Find(house => house.Id == id);
            if(found == null)
            {
                throw new Exception("House with that id not found.");
            }
            return found;
        }

        internal House Create(House data)
        {
            Database.Houses.Add(data);
            return data;
        }

        internal House Edit(House update)
        {
            House edited = GetById(update.Id);

            edited.Year = update.Year;
            edited.Price = update.Price;
            edited.Bathrooms = update.Bathrooms;
            edited.Bedrooms = update.Bedrooms;
            edited.Levels = update.Levels;
            edited.ImgUrl = update.ImgUrl ?? edited.ImgUrl;
            edited.Description = update.Description ?? edited.Description;

            return edited;
        }

        internal House Remove(string id)
        {
            House removed = GetById(id);
            if(Database.Houses.Remove(removed))
            {
                return removed;
            }
            else
            {
                throw new Exception("Unable to remove house.");
            }
        }
    }
}