using Ninject.Modules;
using Bookstore.Domain.Interfaces;
using Bookstore.Infrastructure.Business;
using Bookstore.Infrastructure.Data;
using Bookstore.Services;

namespace Bookstore.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookRepository>().To<BookRepository>();
            Bind<IOrder>().To<CacheOrder>();
            Bind<IOrder>().To<CreditOrder>();
        }
    }
}