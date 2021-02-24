using System.Drawing;

namespace ProData.Infrastructure.LogViewer
{
	public class ErrorLevelDisplay
	{
		public ErrorLevelDisplay(int imageIndex, string text, Color textColor)
		{
			this.ImageIndex = imageIndex;
			this.Text = text;
			this.TextColor = textColor;
		}

		public int ImageIndex { get; set; }
		public string Text { get; set; }
		public Color TextColor { get; set; }
	}
}
