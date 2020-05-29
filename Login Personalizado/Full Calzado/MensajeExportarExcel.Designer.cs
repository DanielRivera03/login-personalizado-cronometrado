namespace Full_Calzado
{
    partial class MensajeExportarExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeExportarExcel));
            this.ContenedorPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Separador = new System.Windows.Forms.PictureBox();
            this.ImgMsj = new System.Windows.Forms.PictureBox();
            this.ContenedorMsj = new System.Windows.Forms.Panel();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbMsj = new System.Windows.Forms.Label();
            this.ContenedorPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMsj)).BeginInit();
            this.ContenedorMsj.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.ColumnCount = 1;
            this.ContenedorPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorPrincipal.Controls.Add(this.panel1, 0, 0);
            this.ContenedorPrincipal.Controls.Add(this.ContenedorMsj, 0, 1);
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContenedorPrincipal.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.RowCount = 2;
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorPrincipal.Size = new System.Drawing.Size(438, 331);
            this.ContenedorPrincipal.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Separador);
            this.panel1.Controls.Add(this.ImgMsj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 165);
            this.panel1.TabIndex = 0;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(66)))));
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(438, 10);
            this.Separador.TabIndex = 4;
            this.Separador.TabStop = false;
            // 
            // ImgMsj
            // 
            this.ImgMsj.Image = ((System.Drawing.Image)(resources.GetObject("ImgMsj.Image")));
            this.ImgMsj.Location = new System.Drawing.Point(94, 19);
            this.ImgMsj.Name = "ImgMsj";
            this.ImgMsj.Size = new System.Drawing.Size(247, 152);
            this.ImgMsj.TabIndex = 0;
            this.ImgMsj.TabStop = false;
            // 
            // ContenedorMsj
            // 
            this.ContenedorMsj.Controls.Add(this.btnRechazar);
            this.ContenedorMsj.Controls.Add(this.btnAceptar);
            this.ContenedorMsj.Controls.Add(this.lbMsj);
            this.ContenedorMsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMsj.Location = new System.Drawing.Point(3, 168);
            this.ContenedorMsj.Name = "ContenedorMsj";
            this.ContenedorMsj.Size = new System.Drawing.Size(432, 160);
            this.ContenedorMsj.TabIndex = 1;
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnRechazar.FlatAppearance.BorderSize = 0;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Kanit ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRechazar.Image = ((System.Drawing.Image)(resources.GetObject("btnRechazar.Image")));
            this.btnRechazar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechazar.Location = new System.Drawing.Point(231, 89);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(80, 47);
            this.btnRechazar.TabIndex = 10;
            this.btnRechazar.Text = "NO";
            this.btnRechazar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Kanit ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(122, 89);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(72, 47);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "SI";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbMsj
            // 
            this.lbMsj.AutoSize = true;
            this.lbMsj.BackColor = System.Drawing.Color.Transparent;
            this.lbMsj.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsj.ForeColor = System.Drawing.Color.White;
            this.lbMsj.Location = new System.Drawing.Point(64, 26);
            this.lbMsj.Name = "lbMsj";
            this.lbMsj.Size = new System.Drawing.Size(278, 29);
            this.lbMsj.TabIndex = 8;
            this.lbMsj.Text = "¿Desea Generar Archivo Excel?";
            // 
            // MensajeExportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(438, 331);
            this.Controls.Add(this.ContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MensajeExportarExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MensajeExportarExcel";
            this.Load += new System.EventHandler(this.MensajeExportarExcel_Load);
            this.ContenedorPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMsj)).EndInit();
            this.ContenedorMsj.ResumeLayout(false);
            this.ContenedorMsj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Separador;
        private System.Windows.Forms.PictureBox ImgMsj;
        private System.Windows.Forms.Panel ContenedorMsj;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbMsj;
    }
}