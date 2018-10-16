using System;
using MioMemberRegistration.Business.KpsServiceReference;
using MioMemberRegistration.Business.ServiceAdapters.Abstract;
using MioMemberRegistration.Entities.Concrete;

namespace MioMemberRegistration.Business.ServiceAdapters.Concrete
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TcNo),
                member.FirstName.ToUpper(),
                member.LastName.ToUpper(),
                 member.DateOfBirth.Year);
        }
    }
}
