using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.Business.ServiceAdapters.Abstract
{
    public interface IKpsService
    {
        bool ValidateUser(Member member);
    }
}
