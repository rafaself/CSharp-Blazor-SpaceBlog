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
	public IActionResult PostContent([FromForm] IFormFile form)
	{
		try
		{
			// Faça o que quiser com os dados do formulário aqui
			Console.WriteLine(form.FileName);

			return Ok("Dados de formulário recebidos com sucesso!");
		}
		catch (Exception ex)
		{
			return Ok();
		}
	}
}
