using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using System.Web.Http;
using Ninject;

namespace Wunderlist.WebUserInterface.DependencyResolver
{
    public class WebAPIDependencyResolver : IDependencyResolver, IDependencyScope
    {
        private IKernel kernel;

        public WebAPIDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose(){}

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

    

}
}