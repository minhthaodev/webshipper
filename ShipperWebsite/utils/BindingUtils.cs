using ShipperWebsite.FirebaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipperWebsite.utils
{
    public class BindingUtils
    {
        public static List<User> UserBinding(Dictionary<String, User> data)
        {
            var model = data.Select(u => new User
            {
                UserID = u.Key,
                Name = u.Value.Name,
                Phone = u.Value.Phone,
                Url = u.Value.Url
            }).ToList();
            return model;
        }
    }
}