using MarketYönetimSistemi.Data;
using MarketYönetimSistemi.Entity;
using MarketYönetimSistemi.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Controller
{
    public class RoleCrud : ICrud<Role>
    {
        DataContext db = new DataContext();
        public bool Add(Role entity)
        {
            if(entity != null && !String.IsNullOrWhiteSpace(entity.Name))
            {
                db.Role.Add(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Role> GetAll()
        {
            return db.Role.Where(x=>x.IsDelete==false).ToList();
        }

        public Role GetById(int id)
        {
            var role = db.Role.Find(id);
            if (role != null)
            {
                return role;
            }
            return null;
        }

        public bool Update(Role entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
