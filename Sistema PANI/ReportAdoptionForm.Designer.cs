namespace Sistema_PANI
{
	partial class ReportAdoptionForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SearchAdoptionTextbox = new MetroFramework.Controls.MetroTextBox();
			this.InfoAdoptionGridView = new MetroFramework.Controls.MetroGrid();
			this.ModifiedAdoptionButton = new MetroFramework.Controls.MetroButton();
			this.DeleteAdoptionButton = new MetroFramework.Controls.MetroButton();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
			((System.ComponentModel.ISupportInitialize)(this.InfoAdoptionGridView)).BeginInit();
			this.metroPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.metroPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(14, 18);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(121, 19);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Buscar Información";
			// 
			// SearchAdoptionTextbox
			// 
			// 
			// 
			// 
			this.SearchAdoptionTextbox.CustomButton.Image = null;
			this.SearchAdoptionTextbox.CustomButton.Location = new System.Drawing.Point(234, 1);
			this.SearchAdoptionTextbox.CustomButton.Name = "";
			this.SearchAdoptionTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.SearchAdoptionTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.SearchAdoptionTextbox.CustomButton.TabIndex = 1;
			this.SearchAdoptionTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.SearchAdoptionTextbox.CustomButton.UseSelectable = true;
			this.SearchAdoptionTextbox.CustomButton.Visible = false;
			this.SearchAdoptionTextbox.Lines = new string[0];
			this.SearchAdoptionTextbox.Location = new System.Drawing.Point(141, 18);
			this.SearchAdoptionTextbox.MaxLength = 32767;
			this.SearchAdoptionTextbox.Name = "SearchAdoptionTextbox";
			this.SearchAdoptionTextbox.PasswordChar = '\0';
			this.SearchAdoptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.SearchAdoptionTextbox.SelectedText = "";
			this.SearchAdoptionTextbox.SelectionLength = 0;
			this.SearchAdoptionTextbox.SelectionStart = 0;
			this.SearchAdoptionTextbox.ShortcutsEnabled = true;
			this.SearchAdoptionTextbox.Size = new System.Drawing.Size(256, 23);
			this.SearchAdoptionTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
			this.SearchAdoptionTextbox.TabIndex = 1;
			this.SearchAdoptionTextbox.UseSelectable = true;
			this.SearchAdoptionTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.SearchAdoptionTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.SearchAdoptionTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HandleFilter);
			// 
			// InfoAdoptionGridView
			// 
			this.InfoAdoptionGridView.AllowUserToAddRows = false;
			this.InfoAdoptionGridView.AllowUserToDeleteRows = false;
			this.InfoAdoptionGridView.AllowUserToResizeRows = false;
			this.InfoAdoptionGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.InfoAdoptionGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.InfoAdoptionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InfoAdoptionGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.InfoAdoptionGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.InfoAdoptionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.InfoAdoptionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.InfoAdoptionGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.InfoAdoptionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InfoAdoptionGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.InfoAdoptionGridView.EnableHeadersVisualStyles = false;
			this.InfoAdoptionGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.InfoAdoptionGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.InfoAdoptionGridView.Location = new System.Drawing.Point(20, 115);
			this.InfoAdoptionGridView.MultiSelect = false;
			this.InfoAdoptionGridView.Name = "InfoAdoptionGridView";
			this.InfoAdoptionGridView.ReadOnly = true;
			this.InfoAdoptionGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.InfoAdoptionGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.InfoAdoptionGridView.RowHeadersVisible = false;
			this.InfoAdoptionGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.InfoAdoptionGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.InfoAdoptionGridView.Size = new System.Drawing.Size(774, 321);
			this.InfoAdoptionGridView.Style = MetroFramework.MetroColorStyle.Yellow;
			this.InfoAdoptionGridView.TabIndex = 3;
			// 
			// ModifiedAdoptionButton
			// 
			this.ModifiedAdoptionButton.Location = new System.Drawing.Point(502, 3);
			this.ModifiedAdoptionButton.Name = "ModifiedAdoptionButton";
			this.ModifiedAdoptionButton.Size = new System.Drawing.Size(109, 23);
			this.ModifiedAdoptionButton.TabIndex = 4;
			this.ModifiedAdoptionButton.Text = "Editar Información";
			this.ModifiedAdoptionButton.UseSelectable = true;
			this.ModifiedAdoptionButton.Click += new System.EventHandler(this.HandleEditClick);
			// 
			// DeleteAdoptionButton
			// 
			this.DeleteAdoptionButton.Location = new System.Drawing.Point(623, 3);
			this.DeleteAdoptionButton.Name = "DeleteAdoptionButton";
			this.DeleteAdoptionButton.Size = new System.Drawing.Size(148, 23);
			this.DeleteAdoptionButton.TabIndex = 5;
			this.DeleteAdoptionButton.Text = "Eliminar Proceso Adopción";
			this.DeleteAdoptionButton.UseSelectable = true;
			this.DeleteAdoptionButton.Click += new System.EventHandler(this.HandleDeleteClick);
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.pictureBox1);
			this.metroPanel1.Controls.Add(this.SearchAdoptionTextbox);
			this.metroPanel1.Controls.Add(this.metroLabel1);
			this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(20, 60);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(774, 55);
			this.metroPanel1.TabIndex = 6;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::Sistema_PANI.Properties.Resources.logo_full;
			this.pictureBox1.Location = new System.Drawing.Point(606, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
			this.pictureBox1.Size = new System.Drawing.Size(168, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// metroPanel2
			// 
			this.metroPanel2.Controls.Add(this.DeleteAdoptionButton);
			this.metroPanel2.Controls.Add(this.ModifiedAdoptionButton);
			this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.metroPanel2.HorizontalScrollbarBarColor = true;
			this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel2.HorizontalScrollbarSize = 10;
			this.metroPanel2.Location = new System.Drawing.Point(20, 436);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Size = new System.Drawing.Size(774, 30);
			this.metroPanel2.TabIndex = 7;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 10;
			// 
			// ReportAdoptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 486);
			this.Controls.Add(this.InfoAdoptionGridView);
			this.Controls.Add(this.metroPanel2);
			this.Controls.Add(this.metroPanel1);
			this.Name = "ReportAdoptionForm";
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Reporte Proceso Adopción";
			((System.ComponentModel.ISupportInitialize)(this.InfoAdoptionGridView)).EndInit();
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.metroPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox SearchAdoptionTextbox;
		private MetroFramework.Controls.MetroGrid InfoAdoptionGridView;
		private MetroFramework.Controls.MetroButton ModifiedAdoptionButton;
		private MetroFramework.Controls.MetroButton DeleteAdoptionButton;
		private MetroFramework.Controls.MetroPanel metroPanel1;
		private MetroFramework.Controls.MetroPanel metroPanel2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}