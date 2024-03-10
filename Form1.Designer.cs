
namespace GeneratePasswordProject
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btgenerate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnletters = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbsymbols = new System.Windows.Forms.CheckBox();
            this.cbdigit = new System.Windows.Forms.CheckBox();
            this.cbupper = new System.Windows.Forms.CheckBox();
            this.cblower = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 32);
            this.textBox1.TabIndex = 0;
            // 
            // btgenerate
            // 
            this.btgenerate.BackColor = System.Drawing.Color.LightCyan;
            this.btgenerate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgenerate.ForeColor = System.Drawing.Color.Navy;
            this.btgenerate.Location = new System.Drawing.Point(472, 126);
            this.btgenerate.Name = "btgenerate";
            this.btgenerate.Size = new System.Drawing.Size(173, 44);
            this.btgenerate.TabIndex = 1;
            this.btgenerate.Text = "Generate";
            this.btgenerate.UseVisualStyleBackColor = false;
            this.btgenerate.Click += new System.EventHandler(this.btgenerate_Click);
            // 
            // btdelete
            // 
            this.btdelete.BackColor = System.Drawing.Color.LightCyan;
            this.btdelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.ForeColor = System.Drawing.Color.Navy;
            this.btdelete.Location = new System.Drawing.Point(672, 126);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(170, 44);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbnletters);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.cbsymbols);
            this.groupBox1.Controls.Add(this.cbdigit);
            this.groupBox1.Controls.Add(this.cbupper);
            this.groupBox1.Controls.Add(this.cblower);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(85, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 230);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(605, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "50";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbnletters
            // 
            this.lbnletters.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnletters.Location = new System.Drawing.Point(305, 96);
            this.lbnletters.Name = "lbnletters";
            this.lbnletters.Size = new System.Drawing.Size(52, 54);
            this.lbnletters.TabIndex = 5;
            this.lbnletters.Text = "1";
            this.lbnletters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.AliceBlue;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(34, 35);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(565, 56);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cbsymbols
            // 
            this.cbsymbols.BackColor = System.Drawing.Color.Azure;
            this.cbsymbols.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsymbols.ForeColor = System.Drawing.Color.Navy;
            this.cbsymbols.Location = new System.Drawing.Point(494, 147);
            this.cbsymbols.Name = "cbsymbols";
            this.cbsymbols.Size = new System.Drawing.Size(133, 47);
            this.cbsymbols.TabIndex = 3;
            this.cbsymbols.Text = "Symbols";
            this.cbsymbols.UseVisualStyleBackColor = false;
            this.cbsymbols.CheckedChanged += new System.EventHandler(this.cbsymbols_CheckedChanged);
            // 
            // cbdigit
            // 
            this.cbdigit.BackColor = System.Drawing.Color.Azure;
            this.cbdigit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdigit.ForeColor = System.Drawing.Color.Navy;
            this.cbdigit.Location = new System.Drawing.Point(363, 147);
            this.cbdigit.Name = "cbdigit";
            this.cbdigit.Size = new System.Drawing.Size(115, 47);
            this.cbdigit.TabIndex = 2;
            this.cbdigit.Text = "Digits";
            this.cbdigit.UseVisualStyleBackColor = false;
            this.cbdigit.CheckedChanged += new System.EventHandler(this.cbsymbols_CheckedChanged);
            // 
            // cbupper
            // 
            this.cbupper.BackColor = System.Drawing.Color.Azure;
            this.cbupper.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbupper.ForeColor = System.Drawing.Color.Navy;
            this.cbupper.Location = new System.Drawing.Point(188, 147);
            this.cbupper.Name = "cbupper";
            this.cbupper.Size = new System.Drawing.Size(150, 47);
            this.cbupper.TabIndex = 1;
            this.cbupper.Text = "UpperCase";
            this.cbupper.UseVisualStyleBackColor = false;
            this.cbupper.CheckedChanged += new System.EventHandler(this.cbsymbols_CheckedChanged);
            // 
            // cblower
            // 
            this.cblower.BackColor = System.Drawing.Color.Azure;
            this.cblower.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblower.ForeColor = System.Drawing.Color.Navy;
            this.cblower.Location = new System.Drawing.Point(6, 147);
            this.cblower.Name = "cblower";
            this.cblower.Size = new System.Drawing.Size(143, 47);
            this.cblower.TabIndex = 0;
            this.cblower.Text = "LowerCase";
            this.cblower.UseVisualStyleBackColor = false;
            this.cblower.CheckedChanged += new System.EventHandler(this.cbsymbols_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(265, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 57);
            this.label4.TabIndex = 4;
            this.label4.Text = "Generate Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(881, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btgenerate);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btgenerate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbnletters;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox cbsymbols;
        private System.Windows.Forms.CheckBox cbdigit;
        private System.Windows.Forms.CheckBox cbupper;
        private System.Windows.Forms.CheckBox cblower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

