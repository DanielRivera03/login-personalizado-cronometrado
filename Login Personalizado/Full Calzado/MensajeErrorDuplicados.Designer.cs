namespace Full_Calzado
{
    partial class MensajeErrorDuplicados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajeErrorDuplicados));
            this.ContenedorVentana = new System.Windows.Forms.TableLayoutPanel();
            this.ContenedorImg = new System.Windows.Forms.Panel();
            this.imgMsj = new System.Windows.Forms.PictureBox();
            this.Separador = new System.Windows.Forms.PictureBox();
            this.ContenedorMsj = new System.Windows.Forms.Panel();
            this.lbMsj = new System.Windows.Forms.Label();
            this.lbMsj2 = new System.Windows.Forms.Label();
            this.lbMsj3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ContenedorVentana.SuspendLayout();
            this.ContenedorImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMsj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).BeginInit();
            this.ContenedorMsj.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContenedorVentana
            // 
            this.ContenedorVentana.ColumnCount = 1;
            this.ContenedorVentana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorVentana.Controls.Add(this.ContenedorImg, 0, 0);
            this.ContenedorVentana.Controls.Add(this.ContenedorMsj, 0, 1);
            this.ContenedorVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorVentana.Location = new System.Drawing.Point(0, 0);
            this.ContenedorVentana.Name = "ContenedorVentana";
            this.ContenedorVentana.RowCount = 2;
            this.ContenedorVentana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorVentana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ContenedorVentana.Size = new System.Drawing.Size(438, 331);
            this.ContenedorVentana.TabIndex = 0;
            // 
            // ContenedorImg
            // 
            this.ContenedorImg.Controls.Add(this.Separador);
            this.ContenedorImg.Controls.Add(this.imgMsj);
            this.ContenedorImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorImg.Location = new System.Drawing.Point(0, 0);
            this.ContenedorImg.Margin = new System.Windows.Forms.Padding(0);
            this.ContenedorImg.Name = "ContenedorImg";
            this.ContenedorImg.Size = new System.Drawing.Size(438, 165);
            this.ContenedorImg.TabIndex = 0;
            // 
            // imgMsj
            // 
            this.imgMsj.Image = ((System.Drawing.Image)(resources.GetObject("imgMsj.Image")));
            this.imgMsj.Location = new System.Drawing.Point(93, 13);
            this.imgMsj.Name = "imgMsj";
            this.imgMsj.Size = new System.Drawing.Size(252, 153);
            this.imgMsj.TabIndex = 0;
            this.imgMsj.TabStop = false;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Red;
            this.Separador.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separador.Location = new System.Drawing.Point(0, 0);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(438, 10);
            this.Separador.TabIndex = 2;
            this.Separador.TabStop = false;
            // 
            // ContenedorMsj
            // 
            this.ContenedorMsj.Controls.Add(this.btnAceptar);
            this.ContenedorMsj.Controls.Add(this.lbMsj3);
            this.ContenedorMsj.Controls.Add(this.lbMsj2);
            this.ContenedorMsj.Controls.Add(this.lbMsj);
            this.ContenedorMsj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorMsj.Location = new System.Drawing.Point(3, 168);
            this.ContenedorMsj.Name = "ContenedorMsj";
            this.ContenedorMsj.Size = new System.Drawing.Size(432, 160);
            this.ContenedorMsj.TabIndex = 1;
            // 
            // lbMsj
            // 
            this.lbMsj.AutoSize = true;
            this.lbMsj.BackColor = System.Drawing.Color.Transparent;
            this.lbMsj.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsj.ForeColor = System.Drawing.Color.White;
            this.lbMsj.Location = new System.Drawing.Point(42, 13);
            this.lbMsj.Name = "lbMsj";
            this.lbMsj.Size = new System.Drawing.Size(346, 29);
            this.lbMsj.TabIndex = 1;
            this.lbMsj.Text = "Lo sentimos, ha ocurrido un problema";
            // 
            // lbMsj2
            // 
            this.lbMsj2.AutoSize = true;
            this.lbMsj2.BackColor = System.Drawing.Color.Transparent;
            this.lbMsj2.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsj2.ForeColor = System.Drawing.Color.Red;
            this.lbMsj2.Location = new System.Drawing.Point(43, 40);
            this.lbMsj2.Name = "lbMsj2";
            this.lbMsj2.Size = new System.Drawing.Size(350, 29);
            this.lbMsj2.TabIndex = 2;
            this.lbMsj2.Text = "No puede insertar registros duplicados";
            // 
            // lbMsj3
            // 
            this.lbMsj3.AutoSize = true;
            this.lbMsj3.BackColor = System.Drawing.Color.Transparent;
            this.lbMsj3.Font = new System.Drawing.Font("Kanit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsj3.ForeColor = System.Drawing.Color.White;
            this.lbMsj3.Location = new System.Drawing.Point(31, 67);
            this.lbMsj3.Name = "lbMsj3";
            this.lbMsj3.Size = new System.Drawing.Size(371, 29);
            this.lbMsj3.TabIndex = 3;
            this.lbMsj3.Text = "Por favor verifique y vuelva a intentarlo...";
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
            this.btnAceptar.Location = new System.Drawing.Point(166, 104);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 47);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MensajeErrorDuplicados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(438, 331);
            this.Controls.Add(this.ContenedorVentana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MensajeErrorDuplicados";
            this.Text = "Lo sentimos, ha ocurrido un problema";
            this.Load += new System.EventHandler(this.MensajeErrorDuplicados_Load);
            this.ContenedorVentana.ResumeLayout(false);
            this.ContenedorImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgMsj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separador)).EndInit();
            this.ContenedorMsj.ResumeLayout(false);
            this.ContenedorMsj.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ContenedorVentana;
        private System.Windows.Forms.Panel ContenedorImg;
        private System.Windows.Forms.PictureBox imgMsj;
        private System.Windows.Forms.PictureBox Separador;
        private System.Windows.Forms.Panel ContenedorMsj;
        private System.Windows.Forms.Label lbMsj3;
        private System.Windows.Forms.Label lbMsj2;
        private System.Windows.Forms.Label lbMsj;
        private System.Windows.Forms.Button btnAceptar;
    }
}