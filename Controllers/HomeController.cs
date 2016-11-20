using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace FirstProjecIos.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var customer = GetCustomer();
			return View(customer);
		}

		public List<Customer> GetCustomer()
		{

			var customers = new List<Customer>();
			customers.Add(new Customer { Id = 1, Name = "Microsft", Address = "Redmond, Washington, ABD" });
			customers.Add(new Customer { Id = 2, Name = "Apple", Address = "Cupertino, Kaliforniya, ABD" });
			return customers;
		}
	}

}
