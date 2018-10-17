using System.Web.Mvc;
using System.Web.Routing;
using FluentValidation.Mvc;
using MioBlog.Core.CrossCuttingConcerns.Validation.FluentValidation;
using MioBlog.Core.Utilities.Mvc.Infrastructure;
using MioMemberRegistration.Business.DependencyResolvers.Ninject;

namespace MioMemberRegistration.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
            FluentValidationModelValidatorProvider.Configure(provider =>
            {
                provider.ValidatorFactory = new NinjectValidationFactory(new ValidationModule());
            });
        }
    }
}
