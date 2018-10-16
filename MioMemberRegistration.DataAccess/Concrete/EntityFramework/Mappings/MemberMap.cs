using System.Data.Entity.ModelConfiguration;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.DataAccess.Concrete.EntityFramework.Mappings
{
   public class MemberMap:EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            ToTable(@"Members", @"dbo");
            HasKey(m => m.MemberId);

            Property(m => m.MemberId).HasColumnName("MemberId");
            Property(m => m.FirstName).HasColumnName("FirstName");
            Property(m => m.LastName).HasColumnName("LastName");
            Property(m => m.DateOfBirth).HasColumnName("DateOfBirth");
            Property(m => m.Email).HasColumnName("Email");
            Property(m => m.TcNo).HasColumnName("TcNo");
        }
    }
}
