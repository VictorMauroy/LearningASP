using Microsoft.EntityFrameworkCore;
using LearningASP.Models;

namespace LearningASP.Data
{
    public class LearningASPContext : DbContext
    {
        public LearningASPContext(DbContextOptions<LearningASPContext> options) : base(options)
        { 
            
        }

        public DbSet<Chapter> Chapters { get; set;}
    }
}
