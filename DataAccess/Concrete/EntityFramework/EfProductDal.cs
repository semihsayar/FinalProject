using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {   
            
            using (NortwindContext context = new NortwindContext())
            {
                // state = durum
                var addedEntity = context.Entry(entity); // referansı yakala
                addedEntity.State = EntityState.Added; // o aslında eklenecek bir nesne
                context.SaveChanges(); // ekle
            }
        }

        public void Delete(Product entity)
        {

            using (NortwindContext context = new NortwindContext())
            {
                
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted; 
                context.SaveChanges(); 
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return filter == null // Filtre Null mı
                    ? context.Set<Product>().ToList() // evet ise
                    :context.Set<Product>().Where(filter).ToList(); // hayır ise
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public void Update(Product entity)
        {
            using (NortwindContext context = new NortwindContext())
            {

                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
