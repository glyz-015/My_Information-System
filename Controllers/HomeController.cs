using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CUMCIS.Models;


namespace CUMCIS.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult People()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();  
        }

        public IActionResult Privacy()
        {
            return View();
        }
 
        public IActionResult Members()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            InfoSys os = new InfoSys();
            ViewData["mem"] = os.getMyembroFromDB();
            return View();
        }

        public IActionResult UserAccounts ()
        {
            InfoSys os = new InfoSys();
            ViewData["mem"] = os.getMyembroFromDB();
            return View();
        }
        public IActionResult Modify()
        {
            InfoSys os = new InfoSys();
            ViewData["mem"] = os.getMyembroFromDB();
            return View();

        }

        public IActionResult Edit (int id)
        {
            InfoSys mem = new InfoSys ();
            ViewData["myembro"] = mem.getmyembro(id);
            return View(); 
        }


        [HttpPost]
      public RedirectResult Edit (int id, string fname, string lname, string suffix, string gender, DateTime bdate, int age, string grp, 
      string contact, string email, string address, string stat, string mname, string marital, string husbandname, string wifename, 
      string children, DateTime anniv, DateTime dod)
        {
            InfoSys mi = new InfoSys();
            Myembro newmem = new Myembro();
            newmem.id = id;
            newmem.fname = fname;
            newmem.lname = lname;
            newmem.suffix = suffix;
            newmem.gender = gender;
            newmem.bdate = bdate;
            newmem.age = age;
            newmem.grp = grp;
            newmem.contact = contact;
            newmem.email = email;
            newmem.address = address;
            newmem.stat = stat;
            newmem.mname = mname;
            newmem.marital = marital;
            newmem.husbandname = husbandname;
            newmem.wifename = wifename;
            newmem.children = children;
            newmem.anniv = anniv;
            newmem.dod = dod;
            mi.UpdateMyembro (newmem);
            return Redirect("/Home/Members");
        }
        

        [HttpPost]
      public RedirectResult Members (int id, string fname, string lname, string suffix, string gender, DateTime bdate, int age, string grp, 
      string contact, string email, string address, string stat, string mname, string marital, string husbandname, string wifename, 
      string children, DateTime anniv, DateTime dod)
        {
            InfoSys mi = new InfoSys();
            Myembro newmem = new Myembro();
            newmem.id = id;
            newmem.fname = fname;
            newmem.lname = lname;
            newmem.suffix = suffix;
            newmem.gender = gender;
            newmem.bdate = bdate;
            newmem.age = age;
            newmem.grp = grp;
            newmem.contact = contact;
            newmem.email = email;
            newmem.address = address;
            newmem.stat = stat;
            newmem.mname = mname;
            newmem.marital = marital;
            newmem.husbandname = husbandname;
            newmem.wifename = wifename;
            newmem.children = children;
            newmem.anniv = anniv;
            newmem.dod = dod;
            mi.addMyembroToDB (newmem);
            return Redirect("/Home/Members");
        }

    }
}
