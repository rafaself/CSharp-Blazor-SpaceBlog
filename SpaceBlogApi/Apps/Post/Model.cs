namespace SpaceBlogApi.Apps.Post;

public class Model
{
	public int Id { get; set; }
	public string Text { get; set; } = string.Empty;
	public byte[]? Image { get; set; }
}
