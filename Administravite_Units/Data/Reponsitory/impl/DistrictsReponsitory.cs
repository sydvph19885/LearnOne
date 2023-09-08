using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reponsitory.impl
{
    public class DistrictsReponsitory : IDistrictsReponsitory
    {
        private readonly MyDbContext _context;
        public DistrictsReponsitory(MyDbContext context)
        {

            _context = context;

        }
        public List<Districs> GetAll()
        {
            return _context.Districts.Include(x => x.Wards).ToList();
        }

        public Districs GetById(int id)
        {
            return _context.Districts.Find(id);
        }
        public Districs Create(Districs district)
        {
            _context.Add(district);
            _context.SaveChanges();
            return district;
        }

        public Districs Update(Districs districs)
        {
            _context.Update(districs);
            _context.SaveChanges();
            return districs;
        }

        public void Delete(int id)
        {
            var district = GetById(id);
            _context.Remove(district);
            _context.SaveChanges();
        }

        public List<Districs> search(string name)
        {
            var districts = GetAll().Where(e => e.Districs_Name.Contains(name)).ToList();
            return districts;
        }
    }
}
