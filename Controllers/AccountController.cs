using AppLearn.Data;
using AppLearn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Session;

namespace AppLearn.Controllers
{
	public class AccountController : Controller
	{
		// GET: Account/Login
		public ActionResult Login()
		{
			// Logic for displaying the login page
			return View(); // Assuming you have a corresponding Login view
		}

		/* POST: Account/Login
		[HttpPost]
		public ActionResult Login(string email, string password)
		{
			// Check if the credentials match a user in the database
			var user = ApplicationDbContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

			if (user != null)
			{
				// If credentials are valid, set authentication cookies or session variables, then redirect to a different page
				// For example, set authentication cookies using ASP.NET Identity
				// This example assumes you're using ASP.NET Identity, otherwise, you would authenticate users securely.
				// Then redirect to a specific page after successful authentication.
				return RedirectToAction("Index", "Home");
			}
			
			else
			{
				// If login fails, return back to the login page with an error message
				ViewBag.ErrorMessage = "Invalid username or password.";
				return View();
			}
		}

		// GET: Account/Logout
		public ActionResult Logout()
		{
			// Logic for logging the user out
			HttpContext.Session.Clear(); // Clear the session or authentication cookies
			return RedirectToAction("Index", "Home"); // Redirect to Home/Index after logout
		}
		*/
	}
}
