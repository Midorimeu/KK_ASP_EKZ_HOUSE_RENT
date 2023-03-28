using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HouseRentalMVCProject.Models;
using System.Data.Entity;

namespace HouseRentalMVCProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();

        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(TblContact tblContact)
        {
           using (HouseRentalDataEntities entities = new HouseRentalDataEntities())
            {
                if (ModelState.IsValid)
                {
                    //(EntityName.TableName.Add(Object Name))  
                    entities.TblContacts.Add(tblContact);

                    entities.SaveChanges();

                    ViewBag.Success = "Feedback Send Successfully";


                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Success = "Feedback Send Successfully";
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Registration(RegisterTbl tblRegistration)
        {
            using (HouseRentalDataEntities entities = new HouseRentalDataEntities())
            {
                if (ModelState.IsValid)
                {
                    //(EntityName.TableName.Add(Object Name))  
                    entities.RegisterTbls.Add(tblRegistration);

                    entities.SaveChanges();

                    ViewBag.Success = "Registration Successfully";


                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Success = "Registration Successfully";
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Booking(BookingTbl tblBooking)
        {
            using (HouseRentalDataEntities entities = new HouseRentalDataEntities())
            {
                if (ModelState.IsValid)
                {
                    //(EntityName.TableName.Add(Object Name))  
                    entities.BookingTbls.Add(tblBooking);

                    entities.SaveChanges();

                    ViewBag.Success = "Pass Booking Successfully";


                    ModelState.Clear();
                }
                else
                {
                    ViewBag.Success = "Pass booking Successfully";
                }
            }
            return View();
        }
        [HttpPost]

        [ValidateAntiForgeryToken]
        public ActionResult Login(RegisterTbl objUser)
        {
            if (ModelState.IsValid)
            {
                using (HouseRentalDataEntities db = new HouseRentalDataEntities())
                {
                    var obj = db.RegisterTbls.Where(a => a.email.Equals(objUser.email) && a.pass.Equals(objUser.pass)).FirstOrDefault();
                    if (obj != null)
                    {
                        //Session["UserID"] = obj.UserId.ToString();
                        //Session["UserName"] = obj.email.ToString();
                        return RedirectToAction("Home/Booking");
                    }
                }
            }
            return View(objUser);
        }
    }
}