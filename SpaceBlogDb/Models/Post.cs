using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Models;

public class Post : IBaseModel
{
	public int Id { get; set; }
	public string Text { get; set; } = string.Empty;
	public string ImageBase64 { get; set; } = string.Empty;
}
