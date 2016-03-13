using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Wunderlist.BusinessLogic.Services.Services.UserService;
using System.Web.Mvc;

namespace Wunderlist.WebUserInterface.DependencyResolver
{
    public class BllToWebDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public BllToWebDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUserService>().To<UserService>();
        }
    }
}