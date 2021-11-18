using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;
using widlife_server.Repos;
using Microsoft.Extensions.Configuration;
using widlife_server.Internal;
using wildlife_server.Models;

namespace widlife_server.Services
{
    public class FishService : IFishService
    {
        private readonly IConfiguration Configuration;
        private readonly IFishRepo FishRepo;

        public FishService(IFishRepo _fishRepo, IConfiguration configuration)
        {
            FishRepo = _fishRepo;
            Configuration = configuration;
        }

        public async Task<ResponseWrapper<ICollection<Fish>>> GetAllFish()
        {
            var fish = await FishRepo.GetAllFish();
            var success = fish != null && fish.Count >= 0;
            var response = new ResponseWrapper<ICollection<Fish>>
            {
                Data = fish,
                Status = success ? "Success" : "Error",
                Success = success
            };

            return response;
        } 

        public async Task<ResponseWrapper<Fish>> GetFishById(int id)
        {
            var fish = await FishRepo.GetFishById(id);
            var success = fish != null;
            var response = new ResponseWrapper<Fish>
            {
                Data = fish,
                Status = success ? "Success" : "Error",
                Success = success
            };

            return response;
        }

        public async Task<ResponseWrapper<Fish>> CreateFish(Fish fish){
            var createdFish = await FishRepo.CreateFish(fish);
            var success = createdFish != null;
            var response = new ResponseWrapper<Fish>
            {
                Data = createdFish,
                Status = success ? "Successfully created fish" : "Error creating fish",
                Success = success
            };

            return response;
        }

    }
}