using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMployeeApi.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> customers{ get; set; }
    }
}
