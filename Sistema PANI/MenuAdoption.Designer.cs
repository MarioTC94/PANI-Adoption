namespace Sistema_PANI
{
	partial class MenuAdoption
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
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.ViewAdoptionProcessButton = new MetroFramework.Controls.MetroButton();
			this.RegisterAdoptionProcessButton = new MetroFramework.Controls.MetroButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.metroPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.ViewAdoptionProcessButton);
			this.metroPanel1.Controls.Add(this.RegisterAdoptionProcessButton);
			this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(20, 60);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(170, 370);
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// ViewAdoptionProcessButton
			// 
			this.ViewAdoptionProcessButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ViewAdoptionProcessButton.Location = new System.Drawing.Point(0, 39);
			this.ViewAdoptionProcessButton.Name = "ViewAdoptionProcessButton";
			this.ViewAdoptionProcessButton.Size = new System.Drawing.Size(170, 48);
			this.ViewAdoptionProcessButton.TabIndex = 3;
			this.ViewAdoptionProcessButton.Text = "Ver Registros";
			this.ViewAdoptionProcessButton.UseSelectable = true;
			this.ViewAdoptionProcessButton.Click += new System.EventHandler(this.HandleViewAdoptions);
			// 
			// RegisterAdoptionProcessButton
			// 
			this.RegisterAdoptionProcessButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.RegisterAdoptionProcessButton.Location = new System.Drawing.Point(0, 0);
			this.RegisterAdoptionProcessButton.Name = "RegisterAdoptionProcessButton";
			this.RegisterAdoptionProcessButton.Size = new System.Drawing.Size(170, 39);
			this.RegisterAdoptionProcessButton.TabIndex = 2;
			this.RegisterAdoptionProcessButton.Text = "Registrar Adopción";
			this.RegisterAdoptionProcessButton.UseSelectable = true;
			this.RegisterAdoptionProcessButton.Click += new System.EventHandler(this.HandleOpenAddAdoptionView);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::Sistema_PANI.Properties.Resources.logo_full;
			this.pictureBox1.Location = new System.Drawing.Point(190, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(590, 370);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// MenuAdoption
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.metroPanel1);
			this.Name = "MenuAdoption";
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Menu Adopción";
			this.metroPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroButton ViewAdoptionProcessButton;
		private MetroFramework.Controls.MetroButton RegisterAdoptionProcessButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}