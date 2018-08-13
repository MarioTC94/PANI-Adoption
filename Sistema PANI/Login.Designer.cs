namespace Sistema_PANI
{
	partial class Login
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.LB_Correo = new MetroFramework.Controls.MetroLabel();
			this.LB_Contra = new MetroFramework.Controls.MetroLabel();
			this.UserEmailLoginTextbox = new MetroFramework.Controls.MetroTextBox();
			this.PasswordUserTextbox = new MetroFramework.Controls.MetroTextBox();
			this.Btn_IniciarSesión = new MetroFramework.Controls.MetroButton();
			this.Btn_Registrarse = new MetroFramework.Controls.MetroButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LB_Correo
			// 
			this.LB_Correo.AutoSize = true;
			this.LB_Correo.Location = new System.Drawing.Point(141, 103);
			this.LB_Correo.Name = "LB_Correo";
			this.LB_Correo.Size = new System.Drawing.Size(51, 19);
			this.LB_Correo.TabIndex = 0;
			this.LB_Correo.Text = "Correo";
			// 
			// LB_Contra
			// 
			this.LB_Contra.AutoSize = true;
			this.LB_Contra.Location = new System.Drawing.Point(141, 146);
			this.LB_Contra.Name = "LB_Contra";
			this.LB_Contra.Size = new System.Drawing.Size(75, 19);
			this.LB_Contra.TabIndex = 1;
			this.LB_Contra.Text = "Contraseña";
			// 
			// UserEmailLoginTextbox
			// 
			// 
			// 
			// 
			this.UserEmailLoginTextbox.CustomButton.Image = null;
			this.UserEmailLoginTextbox.CustomButton.Location = new System.Drawing.Point(131, 1);
			this.UserEmailLoginTextbox.CustomButton.Name = "";
			this.UserEmailLoginTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.UserEmailLoginTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.UserEmailLoginTextbox.CustomButton.TabIndex = 1;
			this.UserEmailLoginTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.UserEmailLoginTextbox.CustomButton.UseSelectable = true;
			this.UserEmailLoginTextbox.CustomButton.Visible = false;
			this.UserEmailLoginTextbox.Lines = new string[0];
			this.UserEmailLoginTextbox.Location = new System.Drawing.Point(258, 103);
			this.UserEmailLoginTextbox.MaxLength = 32767;
			this.UserEmailLoginTextbox.Name = "UserEmailLoginTextbox";
			this.UserEmailLoginTextbox.PasswordChar = '\0';
			this.UserEmailLoginTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.UserEmailLoginTextbox.SelectedText = "";
			this.UserEmailLoginTextbox.SelectionLength = 0;
			this.UserEmailLoginTextbox.SelectionStart = 0;
			this.UserEmailLoginTextbox.ShortcutsEnabled = true;
			this.UserEmailLoginTextbox.Size = new System.Drawing.Size(153, 23);
			this.UserEmailLoginTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
			this.UserEmailLoginTextbox.TabIndex = 2;
			this.UserEmailLoginTextbox.UseSelectable = true;
			this.UserEmailLoginTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.UserEmailLoginTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// PasswordUserTextbox
			// 
			// 
			// 
			// 
			this.PasswordUserTextbox.CustomButton.Image = null;
			this.PasswordUserTextbox.CustomButton.Location = new System.Drawing.Point(131, 1);
			this.PasswordUserTextbox.CustomButton.Name = "";
			this.PasswordUserTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.PasswordUserTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.PasswordUserTextbox.CustomButton.TabIndex = 1;
			this.PasswordUserTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.PasswordUserTextbox.CustomButton.UseSelectable = true;
			this.PasswordUserTextbox.CustomButton.Visible = false;
			this.PasswordUserTextbox.Lines = new string[0];
			this.PasswordUserTextbox.Location = new System.Drawing.Point(258, 146);
			this.PasswordUserTextbox.MaxLength = 32767;
			this.PasswordUserTextbox.Name = "PasswordUserTextbox";
			this.PasswordUserTextbox.PasswordChar = '•';
			this.PasswordUserTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.PasswordUserTextbox.SelectedText = "";
			this.PasswordUserTextbox.SelectionLength = 0;
			this.PasswordUserTextbox.SelectionStart = 0;
			this.PasswordUserTextbox.ShortcutsEnabled = true;
			this.PasswordUserTextbox.Size = new System.Drawing.Size(153, 23);
			this.PasswordUserTextbox.Style = MetroFramework.MetroColorStyle.Yellow;
			this.PasswordUserTextbox.TabIndex = 3;
			this.PasswordUserTextbox.UseSelectable = true;
			this.PasswordUserTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.PasswordUserTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// Btn_IniciarSesión
			// 
			this.Btn_IniciarSesión.Location = new System.Drawing.Point(453, 203);
			this.Btn_IniciarSesión.Name = "Btn_IniciarSesión";
			this.Btn_IniciarSesión.Size = new System.Drawing.Size(75, 23);
			this.Btn_IniciarSesión.TabIndex = 4;
			this.Btn_IniciarSesión.Text = "Iniciar Sesión";
			this.Btn_IniciarSesión.UseSelectable = true;
			this.Btn_IniciarSesión.Click += new System.EventHandler(this.HandleLogIn);
			// 
			// Btn_Registrarse
			// 
			this.Btn_Registrarse.Location = new System.Drawing.Point(556, 203);
			this.Btn_Registrarse.Name = "Btn_Registrarse";
			this.Btn_Registrarse.Size = new System.Drawing.Size(75, 23);
			this.Btn_Registrarse.TabIndex = 5;
			this.Btn_Registrarse.Text = "Registrarse";
			this.Btn_Registrarse.UseSelectable = true;
			this.Btn_Registrarse.Click += new System.EventHandler(this.HandleShowRegiserUserView);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Sistema_PANI.Properties.Resources.logo_full;
			this.pictureBox1.Location = new System.Drawing.Point(531, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 265);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Btn_Registrarse);
			this.Controls.Add(this.Btn_IniciarSesión);
			this.Controls.Add(this.PasswordUserTextbox);
			this.Controls.Add(this.UserEmailLoginTextbox);
			this.Controls.Add(this.LB_Contra);
			this.Controls.Add(this.LB_Correo);
			this.Name = "Login";
			this.Style = MetroFramework.MetroColorStyle.Yellow;
			this.Text = "Login PANI";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel LB_Correo;
		private MetroFramework.Controls.MetroLabel LB_Contra;
		private MetroFramework.Controls.MetroTextBox UserEmailLoginTextbox;
		private MetroFramework.Controls.MetroTextBox PasswordUserTextbox;
		private MetroFramework.Controls.MetroButton Btn_IniciarSesión;
		private MetroFramework.Controls.MetroButton Btn_Registrarse;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

