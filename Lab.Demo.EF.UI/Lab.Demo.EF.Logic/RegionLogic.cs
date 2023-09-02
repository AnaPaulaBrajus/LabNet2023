using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class RegionLogic: BaseLogic, IABMLogic<Region>
    {
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void Add(Region newRegion)
        {
            context.Region.Add(newRegion);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            //var regionAEliminar = context.Region.First(r=>r.RegionID==id);
            //regionAEliminar = context.Region.FirstOrDefault(r => r.RegionID == id);
            //regionAEliminar = context.Region.Single(r => r.RegionID == id);
            //regionAEliminar = context.Region.SingleOrDefault(r => r.RegionID == id);
            var regionAEliminar = context.Region.Find(id);
            context.Region.Remove(regionAEliminar);
            context.SaveChanges();
        }

        public void Update(Region region)
        {
            var regionUpdate = context.Region.Find(region.RegionID);
            regionUpdate.RegionDescription = region.RegionDescription;
            context.SaveChanges();
        }
    }
}
