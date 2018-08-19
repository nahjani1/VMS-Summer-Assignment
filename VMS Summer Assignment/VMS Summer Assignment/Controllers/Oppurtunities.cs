using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMS_Summer_Assignment.Models;
namespace VMS_Summer_Assignment.Controllers
{
    public class OppurtunityContext
    {
        private OppurtunityContext db = new OppurtunityContext();
    }
    public ActionResult Index(string sortOrder, string searchString)
    {
        ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
        var oppurtunity = from s in db.Oppurtunities
                       select s;
        if (!String.IsNullOrEmpty(searchString))
        {
            oppurtunity = oppurtunity.Where(s => s.LastName.Contains(searchString)
                                   || s.FirstMidName.Contains(searchString));
        }
        switch (sortOrder)
        {
            case "name_desc":
                oppurtunity = oppurtunity.OrderByDescending(s => s.LastName);
                break;
            case "Date":
                oppurtunity = oppurtunity.OrderBy(s => s.EnrollmentDate);
                break;
            case "date_desc":
                oppurtunity = oppurtunity.OrderByDescending(s => s.EnrollmentDate);
                break;
            default:
                oppurtunity = oppurtunity.OrderBy(s => s.LastName);
                break;
        }
        return View(oppurtunity.ToList());
    }
}