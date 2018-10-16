using MioBlog.Core.DataAccess.Concretes.EntityFramework;
using MioMemberRegistration.DataAccess.Abstract;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.DataAccess.Concrete.EntityFramework
{
  public  class EfMemberDal:EfEntityRepositoryBase<Member,MioMembershipContext>,IMemberDal
    {
    }
}
