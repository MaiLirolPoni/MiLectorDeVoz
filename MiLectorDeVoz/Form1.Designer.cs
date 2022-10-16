namespace MiLectorDeVoz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Speak = new System.Windows.Forms.Button();
            this.bandeja = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.Speak);
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bandeja);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 98);
            this.panel1.TabIndex = 0;
            // 
            // Speak
            // 
            this.Speak.BackColor = System.Drawing.Color.Transparent;
            this.Speak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Speak.BackgroundImage")));
            this.Speak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Speak.ForeColor = System.Drawing.Color.Turquoise;
            this.Speak.Location = new System.Drawing.Point(709, 19);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(79, 58);
            this.Speak.TabIndex = 4;
            this.Speak.UseVisualStyleBackColor = false;
            this.Speak.Click += new System.EventHandler(this.button5_Click);
            // 
            // bandeja
            // 
            this.bandeja.BackColor = System.Drawing.Color.Transparent;
            this.bandeja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bandeja.BackgroundImage")));
            this.bandeja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bandeja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bandeja.ForeColor = System.Drawing.Color.Turquoise;
            this.bandeja.Location = new System.Drawing.Point(607, 19);
            this.bandeja.Name = "bandeja";
            this.bandeja.Size = new System.Drawing.Size(75, 66);
            this.bandeja.TabIndex = 3;
            this.bandeja.UseVisualStyleBackColor = false;
            this.bandeja.Click += new System.EventHandler(this.bandeja_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.ForeColor = System.Drawing.Color.Turquoise;
            this.stop.Location = new System.Drawing.Point(164, 3);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(83, 74);
            this.stop.TabIndex = 2;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(289, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 74);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(52, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 74);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTxt
            // 
            this.lbTxt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbTxt.Font = new System.Drawing.Font("Tw Cen MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTxt.Location = new System.Drawing.Point(-9, 89);
            this.lbTxt.Name = "lbTxt";
            this.lbTxt.Size = new System.Drawing.Size(817, 371);
            this.lbTxt.TabIndex = 1;
            this.lbTxt.Text = "Lector de texto avanzado";
            this.lbTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTxt);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Button bandeja;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label lbTxt;
    }
}

