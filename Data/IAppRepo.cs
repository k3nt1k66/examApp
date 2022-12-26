using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public interface IAppRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}