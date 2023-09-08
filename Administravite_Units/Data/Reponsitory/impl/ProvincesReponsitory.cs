using Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reponsitory.impl
{
    public class ProvincesReponsitory : IProvincesReponsitory
    {
        private readonly MyDbContext _context;
        public ProvincesReponsitory(MyDbContext context)
        {

            _context = context;

        }

        public Provinces Create(Provinces provinces)
        {
            _context.Add(provinces);
            _context.SaveChanges();
            return provinces;
        }

        public void Delete(int id)
        {
            var provinces = GetById(id);
            _context.Remove(provinces);
            _context.SaveChanges();
        }

        public List<Provinces> GetAll()
        {
            //return _context.Provinces.ToList();
            var list= _context.Provinces.Include(u => u.Districs).ThenInclude(e=> e.Wards).ToList();
            return list.ToList();
        }

        public Provinces GetById(int id)
        {
            return _context.Provinces.Where(x => x.ID == id).Include(x=>x.Districs).FirstOrDefault();
        }

        public List<Provinces> search(string name)
        {
            var ListProvinces = GetAll().Where(pr => pr.Provinces_Name.Contains(name));
            int count = ListProvinces.Count();
            return ListProvinces.ToList();
        }

        public List<Provinces> searchByDistrict(string name)
        {
            return _context.Provinces.Where(p=> p.Districs.Any(x => x.Districs_Name.Contains(name))).Include(x=>x.Districs).ToList();
        }

        public void Update(Provinces provinces)
        {
            _context.Update(provinces);
            _context.SaveChanges(true);
        }
    }
}
