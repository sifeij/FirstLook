using Microsoft.AspNet.Mvc;
using System.Reflection;

namespace FirstLook.Controllers
{
	public class HelloController : Controller
	{
		public string Index()
		{
#if DNX451
            return Assembly.GetExecutingAssembly().FullName;
#endif

#if DNXCORE50
            return typeof(HelloController).AssemblyQualifiedName;
#endif
        }
    }
}