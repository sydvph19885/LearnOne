using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Reponsitory.impl
{
    public class WardsReponsitory : IWardsReponsitory
    {
        private readonly MyDbContext _context;

        public WardsReponsitory(MyDbContext context)
        {
            _context = context;
        }
        public void Create(Wards wards)
        {
            _context.Add(wards);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ward = GetById(id);
            _context.Remove(ward);
            _context.SaveChanges();
        }

        public List<Wards> GetAll()
        {
            return _context.Wards.ToList(); ;
        }

        public Wards GetById(int id)
        {
            return _context.Wards.Find(id);
        }

        public List<Wards> search(string name)
        {
            var search = GetAll().Where(p=> p.Wards_Name.Contains(name));
            return search.ToList();
        }

        public void Update(Wards wards)
        {
            _context.Update(wards);
            _context.SaveChanges();
        }
    }
}
