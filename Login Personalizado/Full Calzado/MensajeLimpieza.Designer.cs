namespace Full_Calzado
{
    partial class MensajeLimpieza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeLimpieza));
            this.ContenedorMensajes = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorImgMSJ = new System.Windows.Forms.Panel();
            this.Separador = new System.Windows.Forms.PictureBox();
            this.ImgMsj = new System.Windows.Forms.PictureBox();
            this.ContenedorAccMsj = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.brnAceptar = new System.Windows.Forms.Button();
            this.lbLimpiezaMsj1 = new System.Windows.Forms.Label();
            this.ContenedorMensajes.SuspendLayout();
            this.ContenedorImgMSJ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMsj)).BeginInit();
            this.ContenedorAccMsj.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorMensajes
            // 
            this.ContenedorMensajes.ColumnCount = 1;
            this.ContenedorMensajes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMensajes.Controls.Add(this.ContenedorImgMSJ, 0, 0);
            this.ContenedorMensajes.Controls.Add(this.ContenedorAccMsj, 0, 1);
            this.ContenedorMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMensajes.Location = new System.Drawing.Point(0, 0);
            this.ContenedorMensajes.Name = "ContenedorMensajes";
            this.ContenedorMensajes.RowCount = 2;
            this.ContenedorMensajes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMensajes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorMensajes.Size = new System.Drawing.Size(438, 331);
            this.ContenedorMensajes.TabIndex = 0;
            // 
            // ContenedorImgMSJ
            // 
            this.ContenedorImgMSJ.Controls.Add(this.Separador);
            this.ContenedorImgMSJ.Controls.Add(this.ImgMsj);
            this.ContenedorImgMSJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorImgMSJ.Location = new System.Drawing.Point(0, 0);
            this.ContenedorImgMSJ.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorImgMSJ.Name = "ContenedorImgMSJ";
            this.ContenedorImgMSJ.Size = new System.Drawing.Size(438, 165);
            this.ContenedorImgMSJ.TabIndex = 0;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(438, 10);
            this.Separador.TabIndex = 2;
            this.Separador.TabStop = false;
            // 
            // ImgMsj
            // 
            this.ImgMsj.Image = ((System.Drawing.Image)(resources.GetObject("ImgMsj.Image")));
            this.ImgMsj.Location = new System.Drawing.Point(102, 17);
            this.ImgMsj.Name = "ImgMsj";
            this.ImgMsj.Size = new System.Drawing.Size(216, 159);
            this.ImgMsj.TabIndex = 0;
            this.ImgMsj.TabStop = false;
            // 
            // ContenedorAccMsj
            // 
            this.ContenedorAccMsj.Controls.Add(this.label1);
            this.ContenedorAccMsj.Controls.Add(this.brnAceptar);
            this.ContenedorAccMsj.Controls.Add(this.lbLimpiezaMsj1);
            this.ContenedorAccMsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorAccMsj.Location = new System.Drawing.Point(3, 168);
            this.ContenedorAccMsj.Name = "ContenedorAccMsj";
            this.ContenedorAccMsj.Size = new System.Drawing.Size(432, 160);
            this.ContenedorAccMsj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kanit", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "¡No te preocupes! Estará disponible al completar los campos";
            // 
            // brnAceptar
            // 
            this.brnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.brnAceptar.FlatAppearance.BorderSize = 0;
            this.brnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnAceptar.Font = new System.Drawing.Font("Kanit ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.brnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("brnAceptar.Image")));
            this.brnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnAceptar.Location = new System.Drawing.Point(161, 93);
            this.brnAceptar.Name = "brnAceptar";
            this.brnAceptar.Size = new System.Drawing.Size(119, 47);
            this.brnAceptar.TabIndex = 4;
            this.brnAceptar.Text = "Aceptar";
            this.brnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.brnAceptar.UseVisualStyleBackColor = false;
            this.brnAceptar.Click += new System.EventHandler(this.brnAceptar_Click);
            // 
            // lbLimpiezaMsj1
            // 
            this.lbLimpiezaMsj1.AutoSize = true;
            this.lbLimpiezaMsj1.BackColor = System.Drawing.Color.Transparent;
            this.lbLimpiezaMsj1.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLimpiezaMsj1.ForeColor = System.Drawing.Color.White;
            this.lbLimpiezaMsj1.Location = new System.Drawing.Point(74, 19);
            this.lbLimpiezaMsj1.Name = "lbLimpiezaMsj1";
            this.lbLimpiezaMsj1.Size = new System.Drawing.Size(288, 29);
            this.lbLimpiezaMsj1.TabIndex = 3;
            this.lbLimpiezaMsj1.Text = "Upss... No hay nada que limpiar";
            // 
            // MensajeLimpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(438, 331);
            this.Controls.Add(this.ContenedorMensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MensajeLimpieza";
            this.Text = "Ups... No hay que limpiar";
            this.Load += new System.EventHandler(this.MensajeLimpieza_Load);
            this.ContenedorMensajes.ResumeLayout(false);
            this.ContenedorImgMSJ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgMsj)).EndInit();
            this.ContenedorAccMsj.ResumeLayout(false);
            this.ContenedorAccMsj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorMensajes;
        private System.Windows.Forms.Panel ContenedorImgMSJ;
        private System.Windows.Forms.PictureBox ImgMsj;
        private System.Windows.Forms.PictureBox Separador;
        private System.Windows.Forms.Panel ContenedorAccMsj;
        private System.Windows.Forms.Button brnAceptar;
        private System.Windows.Forms.Label lbLimpiezaMsj1;
        private System.Windows.Forms.Label label1;
    }
}