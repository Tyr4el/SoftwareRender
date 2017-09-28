namespace SoftwareRenderer
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.renderFrame = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.renderFrame)).BeginInit();
			this.SuspendLayout();
			// 
			// renderFrame
			// 
			this.renderFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.renderFrame.Location = new System.Drawing.Point(0, 0);
			this.renderFrame.Name = "renderFrame";
			this.renderFrame.Size = new System.Drawing.Size(678, 504);
			this.renderFrame.TabIndex = 0;
			this.renderFrame.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(678, 504);
			this.Controls.Add(this.renderFrame);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.renderFrame)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox renderFrame;
	}
}

