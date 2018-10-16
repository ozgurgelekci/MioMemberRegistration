using MioMemberRegistration.Business.Abstract;
using MioMemberRegistration.Business.Concrete;
using MioMemberRegistration.Business.ServiceAdapters.Abstract;
using MioMemberRegistration.Business.ServiceAdapters.Concrete;
using MioMemberRegistration.DataAccess.Abstract;
using MioMemberRegistration.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MioMemberRegistration.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
