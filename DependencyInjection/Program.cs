using Injection;
using Ninject;
using SvcInterface;
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Ioc.Inicializar();

            var svc = Ioc.Kernel.Get<IServiceTest>();

            Console.WriteLine(svc.TestMethod());
        }
    }
}
