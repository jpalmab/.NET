
namespace WinFormsApp1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tCedula = new System.Windows.Forms.TextBox();
            this.tUsuario = new System.Windows.Forms.TextBox();
            this.tClave = new System.Windows.Forms.TextBox();
            this.tIdAdmin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.bAgregar = new MaterialSkin.Controls.MaterialFlatButton();
            this.bModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.bEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.bRefrescar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tCedula
            // 
            this.tCedula.Location = new System.Drawing.Point(91, 137);
            this.tCedula.Name = "tCedula";
            this.tCedula.Size = new System.Drawing.Size(100, 23);
            this.tCedula.TabIndex = 5;
            // 
            // tUsuario
            // 
            this.tUsuario.Location = new System.Drawing.Point(91, 176);
            this.tUsuario.Name = "tUsuario";
            this.tUsuario.Size = new System.Drawing.Size(100, 23);
            this.tUsuario.TabIndex = 7;
            // 
            // tClave
            // 
            this.tClave.Location = new System.Drawing.Point(91, 226);
            this.tClave.Name = "tClave";
            this.tClave.Size = new System.Drawing.Size(100, 23);
            this.tClave.TabIndex = 8;
            // 
            // tIdAdmin
            // 
            this.tIdAdmin.Location = new System.Drawing.Point(91, 88);
            this.tIdAdmin.Name = "tIdAdmin";
            this.tIdAdmin.Size = new System.Drawing.Size(100, 23);
            this.tIdAdmin.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(277, 79);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(331, 185);
            this.dataGridView1.TabIndex = 16;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(21, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Id";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(30, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Cédula";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(30, 176);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(61, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Usuario";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(30, 226);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 21;
            this.materialLabel4.Text = "Clave";
            // 
            // bAgregar
            // 
            this.bAgregar.AutoSize = true;
            this.bAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bAgregar.Depth = 0;
            this.bAgregar.Location = new System.Drawing.Point(9, 273);
            this.bAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Primary = false;
            this.bAgregar.Size = new System.Drawing.Size(74, 36);
            this.bAgregar.TabIndex = 23;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bModificar
            // 
            this.bModificar.AutoSize = true;
            this.bModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bModificar.Depth = 0;
            this.bModificar.Location = new System.Drawing.Point(91, 273);
            this.bModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bModificar.Name = "bModificar";
            this.bModificar.Primary = false;
            this.bModificar.Size = new System.Drawing.Size(84, 36);
            this.bModificar.TabIndex = 24;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.AutoSize = true;
            this.bEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bEliminar.Depth = 0;
            this.bEliminar.Location = new System.Drawing.Point(183, 273);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Primary = false;
            this.bEliminar.Size = new System.Drawing.Size(74, 36);
            this.bEliminar.TabIndex = 25;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bRefrescar
            // 
            this.bRefrescar.AutoSize = true;
            this.bRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bRefrescar.Depth = 0;
            this.bRefrescar.Location = new System.Drawing.Point(396, 273);
            this.bRefrescar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bRefrescar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bRefrescar.Name = "bRefrescar";
            this.bRefrescar.Primary = false;
            this.bRefrescar.Size = new System.Drawing.Size(87, 36);
            this.bRefrescar.TabIndex = 26;
            this.bRefrescar.Text = "Refrescar";
            this.bRefrescar.UseVisualStyleBackColor = true;
            this.bRefrescar.Click += new System.EventHandler(this.bRefrescar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 334);
            this.Controls.Add(this.bRefrescar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tIdAdmin);
            this.Controls.Add(this.tClave);
            this.Controls.Add(this.tUsuario);
            this.Controls.Add(this.tCedula);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tCedula;
        private System.Windows.Forms.TextBox tUsuario;
        private System.Windows.Forms.TextBox tClave;
        private System.Windows.Forms.TextBox tIdAdmin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialFlatButton bAgregar;
        private MaterialSkin.Controls.MaterialFlatButton bModificar;
        private MaterialSkin.Controls.MaterialFlatButton bEliminar;
        private MaterialSkin.Controls.MaterialFlatButton bRefrescar;
    }
}

