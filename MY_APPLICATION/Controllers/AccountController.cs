using System.Linq;

namespace MY_APPLICATION.Controllers
{
    public class AccountController : Infrastructure.BaseController
    {
		public AccountController() : base()
		{
		}

		#region Login
		[System.Web.Mvc.HttpGet]
        public System.Web.Mvc.ViewResult Login()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public System.Web.Mvc.ViewResult Login(ViewModels.Account.LoginViewModel loginViewModel)
        {
            return View();
        }
		#endregion //Login


		#region Register
		[System.Web.Mvc.HttpGet]
        public System.Web.Mvc.ViewResult Register()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.ValidateAntiForgeryToken]
        public System.Web.Mvc.ViewResult Register(ViewModels.Account.RegisterViewModel registerViewModel)
        {
            return View();
        }
		#endregion //Register
	}
}