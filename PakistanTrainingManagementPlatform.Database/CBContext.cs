using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using PakistanTrainingManagementPlatform.Entities;

namespace PakistanTrainingManagementPlatform.Database
{
    public class CBContext:DbContext,IDisposable
    {

        public CBContext():base("PakistanTrainingManagementConnection1")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
