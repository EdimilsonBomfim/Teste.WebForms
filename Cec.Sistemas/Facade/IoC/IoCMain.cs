using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Cec.Sistemas.Facade.Interfaces;

namespace Cec.Sistemas.Facade.IoC
{
    public class IoCMain
    {
        private static readonly object _lockObj = new object();

        private static IWindsorContainer _container = new WindsorContainer();

        public static IWindsorContainer Container
        {
            get { return _container; }
            set
            {
                lock (_lockObj)
                {
                    _container = value;
                }
            }
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public static void RegisterIoC(string assembly)
        {
            Container.Register(
                Classes.FromAssemblyNamed(assembly)
                    .Where(type => type.IsPublic)
                    .WithService.DefaultInterfaces()
                    .Configure(o => o.LifestyleTransient()));
        }

        public static void RegisterAllWithIoC()
        {
            RegisterIoC("Cec.Sistemas");
        }
    }
}