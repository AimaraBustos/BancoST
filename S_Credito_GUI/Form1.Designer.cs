
namespace S_Credito_GUI
{
    partial class Títilo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Títilo));
            this.Titulo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.montoCredito = new System.Windows.Forms.Label();
            this.cantCuotas = new System.Windows.Forms.Label();
            this.txtmontoCredito = new System.Windows.Forms.TextBox();
            this.txtcantCuotas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(223, 20);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(228, 18);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "BIENVENIDO A BANCOST";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(252, 125);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 27);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(64, 134);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(166, 18);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre completo : ";
            // 
            // montoCredito
            // 
            this.montoCredito.AutoSize = true;
            this.montoCredito.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoCredito.Location = new System.Drawing.Point(64, 194);
            this.montoCredito.Name = "montoCredito";
            this.montoCredito.Size = new System.Drawing.Size(168, 18);
            this.montoCredito.TabIndex = 4;
            this.montoCredito.Text = "Monto del crédito : ";
            // 
            // cantCuotas
            // 
            this.cantCuotas.AutoSize = true;
            this.cantCuotas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantCuotas.Location = new System.Drawing.Point(64, 249);
            this.cantCuotas.Name = "cantCuotas";
            this.cantCuotas.Size = new System.Drawing.Size(177, 18);
            this.cantCuotas.TabIndex = 5;
            this.cantCuotas.Text = "Cantidad de cuotas : ";
            this.cantCuotas.Click += new System.EventHandler(this.cantCuotas_Click);
            // 
            // txtmontoCredito
            // 
            this.txtmontoCredito.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontoCredito.Location = new System.Drawing.Point(252, 185);
            this.txtmontoCredito.Name = "txtmontoCredito";
            this.txtmontoCredito.Size = new System.Drawing.Size(199, 27);
            this.txtmontoCredito.TabIndex = 7;
            this.txtmontoCredito.TextChanged += new System.EventHandler(this.txtmontoCredito_TextChanged);
            // 
            // txtcantCuotas
            // 
            this.txtcantCuotas.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantCuotas.Location = new System.Drawing.Point(252, 246);
            this.txtcantCuotas.Name = "txtcantCuotas";
            this.txtcantCuotas.Size = new System.Drawing.Size(199, 27);
            this.txtcantCuotas.TabIndex = 8;
            this.txtcantCuotas.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Iniciar Simulación";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // Títilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcantCuotas);
            this.Controls.Add(this.txtmontoCredito);
            this.Controls.Add(this.cantCuotas);
            this.Controls.Add(this.montoCredito);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.Titulo);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Títilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de crédito";
            this.Load += new System.EventHandler(this.Títilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label montoCredito;
        private System.Windows.Forms.Label cantCuotas;
        private System.Windows.Forms.TextBox txtmontoCredito;
        private System.Windows.Forms.TextBox txtcantCuotas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}

