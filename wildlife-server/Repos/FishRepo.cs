using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wildlife_server.Data;
using wildlife_server.Models;

namespace widlife_server.Repos
{
    public class FishRepo : IFishRepo
    {

        private readonly DataContext Context;
        public FishRepo(DataContext context) => Context = context;

        public async Task<Fish> GetFishById(int id)
        {
            var fish = await Context.Fish.Where(f => f.Id == id).FirstOrDefaultAsync();
            return fish;            
        }
        public async Task<ICollection<Fish>> GetAllFish(){
            var fish = await Context.Fish.ToListAsync();
            return fish;
        }
        public async Task<Fish> CreateFish(Fish fish)
        {
            var createdFish = await Context.Fish.AddAsync(fish);
            await Context.SaveChangesAsync();
            return createdFish.Entity;            
        }
    }
}
