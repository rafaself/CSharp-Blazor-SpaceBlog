using Microsoft.AspNetCore.Mvc;
using SpaceBlogDb.UsesCases;

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
	public async Task<IActionResult> AddFileToPost([FromForm] IEnumerable<IFormFile> files, [FromForm] string text)
	{
		try
		{
			var file = files.FirstOrDefault();

			using var ms = new MemoryStream();

			await file!.CopyToAsync(ms);

			var myArray = ms.ToArray();

			var image64 = Convert.ToBase64String(myArray);

			await PostUseCases.Create(new ()
			{
				Text = text,
				ImageBase64 = image64
			});

            return Ok("Dados de formulário recebidos com sucesso!");
		}
		catch (Exception ex)
		{
			return BadRequest(ex);
		}
	}
}
