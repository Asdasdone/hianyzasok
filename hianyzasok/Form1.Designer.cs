namespace hianyzasok
{
    partial class Form1
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
            this.lbnev = new System.Windows.Forms.Label();
            this.tbnev = new System.Windows.Forms.TextBox();
            this.tbosz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbelso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbutso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbnev
            // 
            this.lbnev.AutoSize = true;
            this.lbnev.Location = new System.Drawing.Point(18, 25);
            this.lbnev.Name = "lbnev";
            this.lbnev.Size = new System.Drawing.Size(27, 13);
            this.lbnev.TabIndex = 0;
            this.lbnev.Text = "Név";
            // 
            // tbnev
            // 
            this.tbnev.Location = new System.Drawing.Point(96, 23);
            this.tbnev.Name = "tbnev";
            this.tbnev.Size = new System.Drawing.Size(178, 20);
            this.tbnev.TabIndex = 1;
            // 
            // tbosz
            // 
            this.tbosz.Location = new System.Drawing.Point(96, 66);
            this.tbosz.Name = "tbosz";
            this.tbosz.Size = new System.Drawing.Size(178, 20);
            this.tbosz.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Osztály";
            // 
            // tbelso
            // 
            this.tbelso.Location = new System.Drawing.Point(96, 108);
            this.tbelso.Name = "tbelso";
            this.tbelso.Size = new System.Drawing.Size(178, 20);
            this.tbelso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Első nap";
            // 
            // tbutso
            // 
            this.tbutso.Location = new System.Drawing.Point(96, 154);
            this.tbutso.Name = "tbutso";
            this.tbutso.Size = new System.Drawing.Size(178, 20);
            this.tbutso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Utolsó nap";
            // 
            // tbmul
            // 
            this.tbmul.Location = new System.Drawing.Point(96, 205);
            this.tbmul.Name = "tbmul";
            this.tbmul.Size = new System.Drawing.Size(178, 20);
            this.tbmul.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mulasztott órák";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(75, 302);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(226, 25);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Hiányzás rögzítése a szeptember.csv-be";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "2017 szeptemberi hiányzások listája";
            // 
            // lblista
            // 
            this.lblista.FormattingEnabled = true;
            this.lblista.Location = new System.Drawing.Point(360, 48);
            this.lblista.Name = "lblista";
            this.lblista.Size = new System.Drawing.Size(390, 368);
            this.lblista.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tbmul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbutso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbelso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbosz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnev);
            this.Controls.Add(this.lbnev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnev;
        private System.Windows.Forms.TextBox tbnev;
        private System.Windows.Forms.TextBox tbosz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbelso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbutso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lblista;
    }
}

