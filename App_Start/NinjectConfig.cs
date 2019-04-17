using Ninject;

using Services.Abstract;
using Services.Concrete;

namespace Tourtech
{
    public class NinjectConfig
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRetailerService>().To<RetailerService>().InSingletonScope();
            kernel.Bind<IProductsService>().To<ProductsService>().InSingletonScope();
            kernel.Bind<IPageContentService>().To<PageContentService>().InSingletonScope();
        }
    }
}