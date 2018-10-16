using FluentValidation;
using MioMemberRegistration.Business.ValidationRules.FluentValidation;
using MioMemberRegistration.Entities.Concrete;
using Ninject.Modules;

namespace MioMemberRegistration.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
