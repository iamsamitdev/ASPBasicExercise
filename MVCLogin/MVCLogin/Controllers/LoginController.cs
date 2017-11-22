using MVCLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

		// Authorize
		[HttpPost]
		public ActionResult Authorize(MVCLogin.Models.User userModel)
		{
			using (OnlineStoreEntities db = new OnlineStoreEntities())
			{
				var userDetails = db.Users.Where(x => x.Username == userModel.Username 
				&& x.Password == userModel.Password).FirstOrDefault();

				if (userDetails == null)
				{
					// Load view login
					return View("Index", userModel);
				}
				else
				{
					// สร้าง session ไว้เช็คที่หน้า dashboard
					Session["userID"] = userDetails.UserID;
					Session["userName"] = userDetails.Username;
					Session["Fullname"] = userDetails.Fullname;

					// Redirect to dashboard
					return RedirectToAction("Index", "Customer");
				}
			}
		}

		// Logout
		public ActionResult Logout()
		{
			Session.RemoveAll();
			return RedirectToAction("Index", "Login");
		}

	}
}