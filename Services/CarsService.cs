using w10d2.FakeDB;
using w10d2.Models;

namespace w10d2.Services
{
    public class CarsService
    {
        internal List<Car> GetAll()
        {
            return Database.Cars;
        }

        internal Car GetById(string id)
        {
            Car found = Database.Cars.Find(car => car.Id == id);
            if(found == null)
            {
                throw new Exception("Could not find car with that id.");
            }
            return found;
        }

        internal Car Create(Car data)
        {
            Database.Cars.Add(data);
            return data;
        }

        internal Car Edit(Car update)
        {
            Car edited = GetById(update.Id);
            
            edited.Make = update.Make ?? edited.Make;
            edited.Model = update.Model ?? edited.Model;
            edited.Color = update.Color ?? edited.Color;
            edited.Year = update.Year;
            edited.Price = update.Price;
            edited.Description = update.Description ?? edited.Description;
            edited.ImgUrl = update.ImgUrl ?? edited.ImgUrl;
            
            return edited;
        }

        internal Car Remove(string id)
        {
            Car removed = GetById(id);
            if(Database.Cars.Remove(removed))
            {
                return removed;
            }
            else
            {
                throw new Exception("Unable to remove car.");
            }
        }
    }
}