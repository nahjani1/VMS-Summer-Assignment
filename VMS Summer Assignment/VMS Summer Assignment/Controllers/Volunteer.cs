﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMS_Summer_Assignment.Models;

namespace VMS_Summer_Assignment.Controllers
{
    public class VolunteerContext
    {
        private VolunteerContext db = new VolunteerContext();
    }
    public ActionResult Index(string sortOrder, string searchString)
    {
        ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
        ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
        var volunteer = from s in db.Volunteer
                          select s;
        if (!String.IsNullOrEmpty(searchString))
        {
            volunteer = volunteer.Where(s => s.LastName.Contains(searchString)
                                   || s.FirstMidName.Contains(searchString));
        }
        switch (sortOrder)
        {
            case "name_desc":
                volunteer = volunteer.OrderByDescending(s => s.LastName);
                break;
            case "Date":
                volunteer = volunteer.OrderBy(s => s.EnrollmentDate);
                break;
            case "date_desc":
                volunteer = volunteer.OrderByDescending(s => s.EnrollmentDate);
                break;
            default:
                volunteer = volunteer.OrderBy(s => s.LastName);
                break;
        }
        return View(volunteer.ToList());
    }
}