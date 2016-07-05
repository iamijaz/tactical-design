using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using ControllerFactoryDemo.Models;

namespace ControllerFactoryDemo.Controllers
{
    public class CustomControllerFactory: IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (controllerName != "Home")
                throw new HttpException((int)HttpStatusCode.NotFound, "Controller not found.");

            return new HomeController(
                new AppSignature()
                {
                    ApplicationName = "Concrete Factory Demo",
                    AuthorName = "Zoran Horvat"
                });
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            if (controller is IDisposable)
                ((IDisposable) controller).Dispose();
        }
    }
}
