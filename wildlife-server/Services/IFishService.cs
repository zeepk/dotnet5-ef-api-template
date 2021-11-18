using System.Collections.Generic;
using System.Threading.Tasks;
using widlife_server.Internal;
using wildlife_server.Models;

namespace widlife_server.Services
{
    public interface IFishService
    {
        Task<ResponseWrapper<ICollection<Fish>>> GetAllFish();
        Task<ResponseWrapper<Fish>> GetFishById(int id);
        Task<ResponseWrapper<Fish>> CreateFish(Fish fish);
    }
}