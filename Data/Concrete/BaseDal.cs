using System;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using Core.DataAccess;

namespace Data.Concrete
{
    public class BaseDal : DbContext
    {
        //public BaseDal(DbContextOptions<BaseDal> options)
        //   : base(options)
        //{ }
        public DbSet<Response> response { get; set; }
    }
}
