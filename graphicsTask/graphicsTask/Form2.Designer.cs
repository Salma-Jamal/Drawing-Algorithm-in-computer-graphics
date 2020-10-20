namespace graphicsTask
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.X0 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.Label();
            this.Y0 = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.Label();
            this.x0textBox = new System.Windows.Forms.TextBox();
            this.y0textBox = new System.Windows.Forms.TextBox();
            this.x1textBox = new System.Windows.Forms.TextBox();
            this.y1textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(181, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bresenham Line Drawing Algorithm";
            this.label5.UseWaitCursor = true;
         
            // 
            // X0
            // 
            this.X0.AccessibleName = "";
            this.X0.AutoSize = true;
            this.X0.BackColor = System.Drawing.Color.Transparent;
            this.X0.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X0.ForeColor = System.Drawing.Color.Gray;
            this.X0.Location = new System.Drawing.Point(72, 133);
            this.X0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(33, 23);
            this.X0.TabIndex = 12;
            this.X0.Text = "X0";
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1.ForeColor = System.Drawing.Color.Gray;
            this.X1.Location = new System.Drawing.Point(72, 222);
            this.X1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(33, 23);
            this.X1.TabIndex = 13;
            this.X1.Text = "X1";
            // 
            // Y0
            // 
            this.Y0.AutoSize = true;
            this.Y0.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y0.ForeColor = System.Drawing.Color.Gray;
            this.Y0.Location = new System.Drawing.Point(259, 222);
            this.Y0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(33, 23);
            this.Y0.TabIndex = 14;
            this.Y0.Text = "Y0";
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y1.ForeColor = System.Drawing.Color.Gray;
            this.Y1.Location = new System.Drawing.Point(259, 133);
            this.Y1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(33, 23);
            this.Y1.TabIndex = 15;
            this.Y1.Text = "Y1";
            // 
            // x0textBox
            // 
            this.x0textBox.BackColor = System.Drawing.Color.White;
            this.x0textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x0textBox.ForeColor = System.Drawing.Color.Gray;
            this.x0textBox.Location = new System.Drawing.Point(121, 135);
            this.x0textBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.x0textBox.Name = "x0textBox";
            this.x0textBox.Size = new System.Drawing.Size(58, 22);
            this.x0textBox.TabIndex = 16;
            this.x0textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y0textBox
            // 
            this.y0textBox.BackColor = System.Drawing.Color.White;
            this.y0textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y0textBox.ForeColor = System.Drawing.Color.Gray;
            this.y0textBox.Location = new System.Drawing.Point(305, 135);
            this.y0textBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.y0textBox.Name = "y0textBox";
            this.y0textBox.Size = new System.Drawing.Size(58, 22);
            this.y0textBox.TabIndex = 17;
            this.y0textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x1textBox
            // 
            this.x1textBox.BackColor = System.Drawing.Color.White;
            this.x1textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x1textBox.ForeColor = System.Drawing.Color.Gray;
            this.x1textBox.Location = new System.Drawing.Point(121, 224);
            this.x1textBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.x1textBox.Name = "x1textBox";
            this.x1textBox.Size = new System.Drawing.Size(58, 22);
            this.x1textBox.TabIndex = 18;
            this.x1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // y1textBox
            // 
            this.y1textBox.BackColor = System.Drawing.Color.White;
            this.y1textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y1textBox.ForeColor = System.Drawing.Color.Gray;
            this.y1textBox.Location = new System.Drawing.Point(305, 222);
            this.y1textBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.y1textBox.Name = "y1textBox";
            this.y1textBox.Size = new System.Drawing.Size(58, 22);
            this.y1textBox.TabIndex = 19;
            this.y1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Font = new System.Drawing.Font("Maven Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(448, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(282, 205);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(517, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 43);
            this.button1.TabIndex = 21;
            this.button1.Text = "Show Line";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(30, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 40;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.y1textBox);
            this.Controls.Add(this.x1textBox);
            this.Controls.Add(this.y0textBox);
            this.Controls.Add(this.x0textBox);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.label5);
            this.Name = "Form2";
            this.Text = "Bresenham Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label X0;
        private System.Windows.Forms.Label X1;
        private System.Windows.Forms.Label Y0;
        private System.Windows.Forms.Label Y1;
        private System.Windows.Forms.TextBox x0textBox;
        private System.Windows.Forms.TextBox y0textBox;
        private System.Windows.Forms.TextBox x1textBox;
        private System.Windows.Forms.TextBox y1textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}