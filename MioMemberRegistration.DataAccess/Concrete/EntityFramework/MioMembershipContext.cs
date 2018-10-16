using System.Data.Entity;
using MioMemberRegistration.DataAccess.Concrete.EntityFramework.Mappings;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class MioMembershipContext:DbContext
    {
        public MioMembershipContext()
        {
            Database.SetInitializer<MioMembershipContext>(null);
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
    }
}
