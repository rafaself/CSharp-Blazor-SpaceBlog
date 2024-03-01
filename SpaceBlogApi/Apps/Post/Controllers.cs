using Microsoft.AspNetCore.Mvc;

namespace SpaceBlogApi.Apps.Post;


[ApiController]
[Route("/HelloWorld")]
public class Controllers : ControllerBase
{
	[HttpGet]
	public ActionResult<string> SayHelloWorld()
	{
		return "Hello World!";
	}

	[HttpPost]
	public IActionResult PostContent([FromForm] IEnumerable<IFormFile> form)
	{
		Console.WriteLine("chamou o endpoint");
		try
		{
			Console.WriteLine(form);
			return Ok("Dados de formulário recebidos com sucesso!");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			return Ok();
		}
	}
}
