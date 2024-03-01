namespace SpaceBlogApi.Apps.Post;

public class PostModel(string text)
{
	public int Id { get; set; }
	public string Text { get; set; } = text;
	//public byte[]? Image { get; set; }
}
