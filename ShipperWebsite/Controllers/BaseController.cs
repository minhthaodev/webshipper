using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Web.Mvc;
using ShipperWebsite.Models.ShipperAdmin;
using FireSharp.Serialization.ServiceStack;
using FireSharp.Serialization.JsonNet;


namespace ShipperWebsite.Controllers
{
    public class BaseController : Controller
    {
        protected bool CheckLogin { get; set; }
        protected IFirebaseClient FirebaseClient { get; set; }
        public BaseController()
        {
            CheckLogin = false;
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "NZwwulkpTObLaSLCjrN4Ichwu6cUfd7uccJi61ej",
                BasePath = "https://shipperv2.firebaseio.com/"
            };
            config.Serializer = new ServiceStackJsonSerializer(); //Register ServiceStack.Text
            config.Serializer = new JsonNetSerializer();          //Register Json.Net
            FirebaseClient = new FirebaseClient(config);
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (CheckLogin) {
                var sess = (UserAdmin)Session[Constants.USER_SESSION];
                if (sess == null)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new System.Web.Routing.RouteValueDictionary(new { controller = "Login", action = "Index" }));
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}