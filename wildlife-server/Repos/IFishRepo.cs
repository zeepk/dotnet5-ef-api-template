using System.Collections.Generic;
using System.Threading.Tasks;
using wildlife_server.Models;

namespace widlife_server.Repos
{
    public interface IFishRepo
    {
        Task<ICollection<Fish>> GetAllFish();
        Task<Fish> GetFishById(int id);
        Task<Fish> CreateFish(Fish fish);
    }
}
