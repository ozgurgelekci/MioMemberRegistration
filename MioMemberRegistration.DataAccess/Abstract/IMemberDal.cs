using MioBlog.Core.DataAccess.Abstracts;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.DataAccess.Abstract
{
    public interface IMemberDal : IEntityRepository<Member>
    {

    }
}
