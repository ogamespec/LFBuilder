using System.Drawing.Imaging;

// ChatGPT Prompt:
// Напиши на C# программу на WinForms, которая выбирает 18 картинок квадратного размера, сгруппированные 6 в ширину и 3 в высоту. Картинки находятся как .jpg файлы в папке рядом с программой. Программа должна уметь выгружать полученное "панно" в виде картинки (jpg или png)

namespace LFBuilder
{
	public partial class Form1 : Form
	{
		private const int ImageSize = 100; // размер картинок (100x100 pixels)
		private readonly string imagesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

		public Form1()
		{
			InitializeComponent();
			//LoadImages();
		}

		private void LoadImages()
		{
			if (!Directory.Exists(imagesFolder))
			{
				MessageBox.Show($"Папка не найдена: {imagesFolder}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var imageFiles = Directory.GetFiles(imagesFolder, "*.jpg").Take(18).ToList();
			if (imageFiles.Count < 18)
			{
				MessageBox.Show("Не найдено достаточное количество изображений (нужны 18 .jpg файлов).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			foreach (var imageFile in imageFiles)
			{
				AddImageToFlow(imageFile);
			}
		}

		private void AddImageToFlow(string imageFile)
		{
			var pictureBox = new PictureBox
			{
				Width = ImageSize,
				Height = ImageSize,
				Image = Image.FromFile(imageFile),
				SizeMode = PictureBoxSizeMode.StretchImage
			};
			flowLayoutPanel1.Controls.Add(pictureBox);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var bitmap = new Bitmap(flowLayoutPanel1.Width, flowLayoutPanel1.Height))
			{
				flowLayoutPanel1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "JPEG Image|*.jpg|PNG Image|*.png",
					Title = "Сохранить панно как"
				};

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					var format = saveFileDialog.FilterIndex == 1 ? ImageFormat.Jpeg : ImageFormat.Png;
					bitmap.Save(saveFileDialog.FileName, format);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				AddImageToFlow(openFileDialog1.FileName);
			}
		}
	}
}
