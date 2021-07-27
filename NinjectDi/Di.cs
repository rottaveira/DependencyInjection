using Ninject;
using Ninject.Extensions.Conventions; 
using Svc;
using SvcInterface;
using Dao;
using DaoInterface;
using Ninject.Modules;

namespace NinjectDi
{
    public class Di 
    {
        private static StandardKernel _kernel;

        public static StandardKernel Kernel
        {
            get { return _kernel; }
            set { _kernel = value; }
        }

        public static void Inicializar()
        {
            Kernel = new StandardKernel();

            /*Binding Manual*/
            // Kernel.Bind<IServiceTest>().To<ServiceTest>();
            // Kernel.Bind<IDaoTest>().To<DaoTest>();

            /* Binding Genérico Dao*/
            Kernel.Bind(cfg =>
            {
                cfg.FromAssembliesMatching("Dao*")
                .SelectAllClasses()
                .BindAllInterfaces()
                .Configure(c => c.InTransientScope()) ;
            });


            /* Binding genérico SVC */
            Kernel.Bind(cfg =>
            {
                cfg.FromAssembliesMatching("Svc*")
                    .SelectAllClasses()
                    .BindAllInterfaces()
                    .Configure(c => c.InTransientScope());
            });
        }
 
    }
}
