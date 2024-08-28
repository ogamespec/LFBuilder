namespace LFBuilder
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			splitContainer1 = new SplitContainer();
			flowLayoutPanel1 = new FlowLayoutPanel();
			button2 = new Button();
			button1 = new Button();
			openFileDialog1 = new OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(button2);
			splitContainer1.Panel2.Controls.Add(button1);
			splitContainer1.Size = new Size(769, 393);
			splitContainer1.SplitterDistance = 348;
			splitContainer1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(769, 348);
			flowLayoutPanel1.TabIndex = 0;
			// 
			// button2
			// 
			button2.Location = new Point(12, 7);
			button2.Name = "button2";
			button2.Size = new Size(102, 30);
			button2.TabIndex = 1;
			button2.Text = "Добавить теху";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(120, 6);
			button1.Name = "button1";
			button1.Size = new Size(96, 32);
			button1.TabIndex = 0;
			button1.Text = "Сохранить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.DefaultExt = "jpg";
			openFileDialog1.Filter = "Image files|*.jpg;*.png|All files|*.*";
			openFileDialog1.InitialDirectory = "./Images";
			openFileDialog1.Title = "Выберите картинку техи ФЖ из папки Images";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(769, 393);
			Controls.Add(splitContainer1);
			Name = "Form1";
			Text = "LFBuilder by ogamespec and ChatGPT";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button button1;
		private Button button2;
		private OpenFileDialog openFileDialog1;
	}
}
