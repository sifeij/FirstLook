using Microsoft.AspNet.Mvc;

namespace FirstLook.Controllers
{
	public class HelloController : Controller
	{
		public string Index()
		{
			return "Hello, World!";
		}
	}
}