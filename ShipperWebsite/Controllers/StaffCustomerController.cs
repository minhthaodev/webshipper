using Newtonsoft.Json;
using ShipperWebsite.FirebaseModel;
using ShipperWebsite.FirebaseModel.FirebaseMessage;
using ShipperWebsite.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ShipperWebsite.core;

namespace ShipperWebsite.Controllers
{
    public class StaffCustomerController : BaseController
    {
        public StaffCustomerController()
        {
            CheckLogin = false;
        }
        //
        // GET: /StaffCustomerCustomer/
        public async Task<ActionResult> Index()
        {
            var usersChild = await FirebaseClient.GetTaskAsync("users");
            var users = usersChild.ResultAs<Dictionary<String, User>>();
            var model = users.Select(u => new User
            {
                UserID = u.Key,
                Name = u.Value.Name,
                Phone = u.Value.Phone,
                Url = u.Value.Url,
                Permission = u.Value.Permission
            }).ToList();
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(String id)
        {
            if (id == null)
            {
                return new HttpNotFoundResult();
            }
            var userChild = FirebaseClient.Get("users/" + id);
            var model = userChild.ResultAs<User>();
            if (model == null) return new HttpNotFoundResult();
            model.UserID = id;
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            var newUpdate = new
            {
                name = user.Name,
                phone = user.Phone
            };
            FirebaseClient.Update("users/" + user.UserID, newUpdate);

            return RedirectToAction("Index", "StaffCustomer");
        }


       

        [HttpPost]
       
        public ActionResult Add()
        {
            var model = new User();
            return View(model);
        }
    }
}