
namespace WinFormsApp1
{
    partial class Login
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
            this.tUsuarioLogin = new System.Windows.Forms.TextBox();
            this.tClaveLogin = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.bEntrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // tUsuarioLogin
            // 
            this.tUsuarioLogin.Location = new System.Drawing.Point(117, 95);
            this.tUsuarioLogin.Name = "tUsuarioLogin";
            this.tUsuarioLogin.Size = new System.Drawing.Size(116, 23);
            this.tUsuarioLogin.TabIndex = 0;
            // 
            // tClaveLogin
            // 
            this.tClaveLogin.Location = new System.Drawing.Point(117, 148);
            this.tClaveLogin.Name = "tClaveLogin";
            this.tClaveLogin.PasswordChar = '*';
            this.tClaveLogin.Size = new System.Drawing.Size(116, 23);
            this.tClaveLogin.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 152);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Clave";
            // 
            // bEntrar
            // 
            this.bEntrar.Depth = 0;
            this.bEntrar.Location = new System.Drawing.Point(117, 201);
            this.bEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Primary = true;
            this.bEntrar.Size = new System.Drawing.Size(116, 38);
            this.bEntrar.TabIndex = 8;
            this.bEntrar.Text = "Entrar";
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 251);
            this.Controls.Add(this.bEntrar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tClaveLogin);
            this.Controls.Add(this.tUsuarioLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUsuarioLogin;
        private System.Windows.Forms.TextBox tClaveLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton bEntrar;
    }
}