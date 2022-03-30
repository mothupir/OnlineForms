using Microsoft.EntityFrameworkCore;
using OnlineForms.Shared.Models;

namespace OnlineForms.Server.Services
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<FilledForm> FilledForms { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormAssignment> FormAssignments { get; set; }
        public DbSet<FormStatus> FormStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
    }
}
