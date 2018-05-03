using System;
using System.ComponentModel.DataAnnotations;


namespace ShipperWebsite.ViewModel
{
    public class StaffContactViewModel
    {
        public String UserId { get; set; }

        [Required]
        public String Title { get; set; }

        [Required]
        public String Message { get; set; }
    }
}