using Ninject;

namespace MioMemberRegistration.Business.DependencyResolvers.Ninject
{
   public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
