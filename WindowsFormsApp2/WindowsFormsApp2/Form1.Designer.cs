namespace WindowsFormsApp2
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Discriminant = new System.Windows.Forms.Button();
            this.abb = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(203, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algebraic calculator";
            // 
            // Discriminant
            // 
            this.Discriminant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Discriminant.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Discriminant.Location = new System.Drawing.Point(530, 31);
            this.Discriminant.Name = "Discriminant";
            this.Discriminant.Size = new System.Drawing.Size(193, 97);
            this.Discriminant.TabIndex = 1;
            this.Discriminant.Text = "Discriminant";
            this.Discriminant.UseVisualStyleBackColor = false;
            this.Discriminant.Click += new System.EventHandler(this.Discriminant_Click);
            // 
            // abb
            // 
            this.abb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.abb.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abb.Location = new System.Drawing.Point(530, 273);
            this.abb.Name = "abb";
            this.abb.Size = new System.Drawing.Size(193, 97);
            this.abb.TabIndex = 2;
            this.abb.Text = "Abbreviated multiplication (a-b)^2";
            this.abb.UseVisualStyleBackColor = false;
            this.abb.Click += new System.EventHandler(this.abb_Click);
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.test.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test.Location = new System.Drawing.Point(32, 31);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(193, 97);
            this.test.TabIndex = 3;
            this.test.Text = "Abbreviated multiplication (a+b)^2";
            this.test.UseVisualStyleBackColor = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(32, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 96);
            this.button1.TabIndex = 4;
            this.button1.Text = "CIRCLE area";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.abb);
            this.Controls.Add(this.Discriminant);
            this.Controls.Add(this.label1);
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Discriminant;
        private System.Windows.Forms.Button abb;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button button1;
    }
}

