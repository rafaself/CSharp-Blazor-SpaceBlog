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
	public IActionResult AddFileToPost([FromForm] IEnumerable<IFormFile> files, [FromQuery] int id)
	{
		Console.WriteLine("chamou o endpoint");
		try
		{
			Console.WriteLine(files);
			Console.WriteLine(files.Count());
			return Ok("Dados de formulário recebidos com sucesso!");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			return Ok();
		}
	}
}
