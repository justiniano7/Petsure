using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetSure.Helpers
{
    public class SiteHelpers
    {
        public List<SelectListItem> GetPetsOwned()
        {


            //Rover, Fido, Pixie.
            List<SelectListItem> list = new List<SelectListItem>();

            var newItem = new SelectListItem { Text = "Rover", Value = "1" };
            var newItem1 = new SelectListItem { Text = "Fido", Value = "2" };
            var newItem2 = new SelectListItem { Text = "Pixie", Value = "3" };
            list.Add(newItem);
            list.Add(newItem1);
            list.Add(newItem2);


            return list;
        }
    }
}