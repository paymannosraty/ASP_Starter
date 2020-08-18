using System.Linq;

namespace MY_APPLICATION.Controllers
{
	public partial class HomeController : Infrastructure.BaseController
	{
		// GET: Home
		[System.Web.Mvc.HttpGet]
		public virtual System.Web.Mvc.ViewResult Index()
		{
			return View();
		}
	}
}