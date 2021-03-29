using DogGo.Models;
using System.Collections.Generic;


namespace DogGo.Repositories
{
    public class IDogRepository
    {
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        void AddDog(Dog dog);
        void UpdateDog(Dog dog);
        void DeleteDog(int dogId);
    }
}
