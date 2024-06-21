namespace ChainOfResposibilility
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
            this.btnReason = new System.Windows.Forms.Button();
            this.txtName = new MyControlsHelper.RJtextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrawingNumber = new MyControlsHelper.RJtextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortNumber = new MyControlsHelper.RJtextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBudget = new MyControlsHelper.RJtextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReason
            // 
            this.btnReason.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReason.Location = new System.Drawing.Point(204, 381);
            this.btnReason.Name = "btnReason";
            this.btnReason.Size = new System.Drawing.Size(130, 45);
            this.btnReason.TabIndex = 0;
            this.btnReason.Text = "Reason";
            this.btnReason.UseVisualStyleBackColor = true;
            this.btnReason.Click += new System.EventHandler(this.btnReason_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 0;
            this.txtName.BorderSize = -1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(138, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(250, 30);
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "New material";
            this.txtName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtDrawingNumber
            // 
            this.txtDrawingNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtDrawingNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDrawingNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDrawingNumber.BorderRadius = 0;
            this.txtDrawingNumber.BorderSize = 2;
            this.txtDrawingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrawingNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDrawingNumber.Location = new System.Drawing.Point(138, 88);
            this.txtDrawingNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrawingNumber.Multiline = false;
            this.txtDrawingNumber.Name = "txtDrawingNumber";
            this.txtDrawingNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDrawingNumber.PasswordChar = false;
            this.txtDrawingNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDrawingNumber.PlaceholderText = "";
            this.txtDrawingNumber.Size = new System.Drawing.Size(250, 30);
            this.txtDrawingNumber.TabIndex = 1;
            this.txtDrawingNumber.Texts = "#1561_DS56S";
            this.txtDrawingNumber.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drawing Number";
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPortNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPortNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPortNumber.BorderRadius = 0;
            this.txtPortNumber.BorderSize = -1;
            this.txtPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPortNumber.Location = new System.Drawing.Point(138, 149);
            this.txtPortNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortNumber.Multiline = false;
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPortNumber.PasswordChar = false;
            this.txtPortNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPortNumber.PlaceholderText = "";
            this.txtPortNumber.Size = new System.Drawing.Size(250, 30);
            this.txtPortNumber.TabIndex = 1;
            this.txtPortNumber.Texts = "5153-6635";
            this.txtPortNumber.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PortNumber";
            // 
            // txtBudget
            // 
            this.txtBudget.BackColor = System.Drawing.SystemColors.Window;
            this.txtBudget.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBudget.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBudget.BorderRadius = 0;
            this.txtBudget.BorderSize = 2;
            this.txtBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBudget.Location = new System.Drawing.Point(138, 211);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(4);
            this.txtBudget.Multiline = false;
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBudget.PasswordChar = false;
            this.txtBudget.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBudget.PlaceholderText = "";
            this.txtBudget.Size = new System.Drawing.Size(250, 30);
            this.txtBudget.TabIndex = 1;
            this.txtBudget.Texts = "9500";
            this.txtBudget.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(183, -251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Material Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(209, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Material Order";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtResult.Location = new System.Drawing.Point(138, 264);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(250, 98);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 438);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.txtDrawingNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnReason);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReason;
        private MyControlsHelper.RJtextBox txtName;
        private System.Windows.Forms.Label label1;
        private MyControlsHelper.RJtextBox txtDrawingNumber;
        private System.Windows.Forms.Label label2;
        private MyControlsHelper.RJtextBox txtPortNumber;
        private System.Windows.Forms.Label label3;
        private MyControlsHelper.RJtextBox txtBudget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResult;
    }
}

