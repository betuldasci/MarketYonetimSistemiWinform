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
    public class UserCrud : ICrud<User>
    {
        DataContext db = new DataContext();
        public bool Add(User entity)
        {
            if(entity != null && !String.IsNullOrWhiteSpace(entity.Email )
                              && !String.IsNullOrWhiteSpace(entity.Password))
            {
                db.User.Add(entity);
                db.SaveChanges();
                return true;
            }
        
            return false;
        }

        public bool Delete(int id)
        {
            var user = db.User.Find(id);
            if (user != null)
            {
                user.IsDelete = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<User> GetAll()
        {
            return db.User.Where(x=>x.IsDelete==false).ToList();
        }

        public User GetById(int id)
        {
            var user = db.User.Find(id);
            if(user != null)
            {
                return user;
            }
            return null;
        }

        public bool Update(User entity, int id)
        {
            var existingUser = db.User.Find(id);

            if (existingUser != null && entity != null)
            {
                existingUser.Name = entity.Name;
                existingUser.Surname = entity.Surname;
                existingUser.Email = entity.Email;
                existingUser.Description = entity.Description;
                existingUser.RoleId = entity.RoleId;
                existingUser.IsStatus = entity.IsStatus;
                existingUser.Image = entity.Image;

                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
