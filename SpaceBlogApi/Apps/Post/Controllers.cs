using Microsoft.AspNetCore.Mvc;

namespace SpaceBlogApi.Apps.Post;


[ApiController]
[Route("/HelloWorld")]
public class Controllers
{
	[HttpGet]
	public ActionResult<string> SayHelloWorld()
	{
		return "Hello World!";
	}
}
