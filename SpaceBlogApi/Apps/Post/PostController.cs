using Microsoft.AspNetCore.Mvc;

namespace SpaceBlogApi.Apps.Post;


[ApiController]
[Route("/Post")]
public class PostController : ControllerBase
{
	[HttpGet]
	public ActionResult<string> SayHelloWorld()
	{
		return "Hello World do Post!";
	}


	[HttpPost]
	public void CreatePost([FromBody] PostModel post)
	{
		Console.WriteLine(post.Text);
		Console.WriteLine("chama");
		//PostModel Post = new PostModel(text);
	}

	[HttpPost("AddFile")]
	public IActionResult AddFileToPost([FromForm] IEnumerable<IFormFile> form, [FromQuery] int id)
	{
		Console.WriteLine("chamou o endpoint");
		Console.WriteLine(id);
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
