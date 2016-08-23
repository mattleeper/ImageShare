using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ImageShare.Data.Models;
using ImageShare.Data.Mapping;
using System.Data.Entity.Infrastructure;

namespace ImageShare.Data.Context
{
    public interface IDataContext
    {
        IDbSet<Image> Image { get; set; }

        DbEntityEntry Entry(object entity);
        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        DbSet<T> Set<T>() where T : class;
    }

    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
        }

        public DataContext(string connectionString)
            : base(connectionString)
        {

        }

        public IDbSet<Image> Image { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null) return; 

            modelBuilder.Configurations.Add(new ImageMap());
        }
    }
}
