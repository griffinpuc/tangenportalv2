using Microsoft.EntityFrameworkCore;

namespace tangen
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<RunMod> TrackersTable { get; set; }


        public void AddEntry(object obj)
        {
            Add(obj);
            SaveChanges();
        }

        /* Remove entry */
        public void RemoveEntry(object obj)
        {
            Remove(obj);
            SaveChanges();
        }

        /* Modify entry */
        public void UpdateEntry(object obj)
        {
            Update(obj);
            SaveChanges();
        } 
    }
}