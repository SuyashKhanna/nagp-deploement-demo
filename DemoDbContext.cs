using Microsoft.EntityFrameworkCore;
using Web_Application;

namespace nagp_deployment_demo
{
    public class DemoDbContext : DbContext
    {
        public DbSet<Demo> Demo { get; set;} 
    }
}