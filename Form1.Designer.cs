namespace BMIcalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBerekenen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGewicht = new System.Windows.Forms.TextBox();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblAdvies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lengte in CM:";
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(193, 109);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(100, 22);
            this.txtLengte.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "BMI Calculator\r\n";
            // 
            // btnBerekenen
            // 
            this.btnBerekenen.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBerekenen.Location = new System.Drawing.Point(84, 288);
            this.btnBerekenen.Name = "btnBerekenen";
            this.btnBerekenen.Size = new System.Drawing.Size(351, 107);
            this.btnBerekenen.TabIndex = 3;
            this.btnBerekenen.Text = "BMI berekenen";
            this.btnBerekenen.UseVisualStyleBackColor = true;
            this.btnBerekenen.Click += new System.EventHandler(this.btnBerekenen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gewichg in KG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Leeftijd\r\n";
            // 
            // txtGewicht
            // 
            this.txtGewicht.Location = new System.Drawing.Point(193, 152);
            this.txtGewicht.Name = "txtGewicht";
            this.txtGewicht.Size = new System.Drawing.Size(100, 22);
            this.txtGewicht.TabIndex = 6;
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(193, 193);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.txtLeeftijd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "BMI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Advies";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(193, 439);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(46, 17);
            this.lblBMI.TabIndex = 10;
            this.lblBMI.Text = "label7";
            // 
            // lblAdvies
            // 
            this.lblAdvies.AutoSize = true;
            this.lblAdvies.Location = new System.Drawing.Point(193, 483);
            this.lblAdvies.Name = "lblAdvies";
            this.lblAdvies.Size = new System.Drawing.Size(46, 17);
            this.lblAdvies.TabIndex = 11;
            this.lblAdvies.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 613);
            this.Controls.Add(this.lblAdvies);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.txtGewicht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBerekenen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLengte);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBerekenen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGewicht;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblAdvies;
    }
}

