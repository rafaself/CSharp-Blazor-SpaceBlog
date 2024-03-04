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
	public async Task<IActionResult> AddFileToPost([FromForm] IEnumerable<IFormFile> files, [FromForm] string texto)
	{
		Console.WriteLine(texto);
		try
		{
			var file = files.FirstOrDefault();
			using var ms = new MemoryStream();

			await file!.CopyToAsync(ms);

			var myArray = ms.ToArray();

			var image64 = Convert.ToBase64String(myArray);

            foreach (var item in image64)
            {
				Console.Write(item);
            }

            return Ok("Dados de formulário recebidos com sucesso!");
		}
		catch (Exception ex)
		{
			return Ok();
		}
	}
}
