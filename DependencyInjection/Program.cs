using NinjectDi;
using Ninject;
using SvcInterface;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Di.Inicializar();

            var svc = Di.Kernel.Get<IServiceTest>();

            Console.WriteLine(svc.TestMethod());
        }
    }
}
