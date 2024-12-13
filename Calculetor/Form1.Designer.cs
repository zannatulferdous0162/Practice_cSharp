namespace Calculetor
{
    partial class Form1
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblFirstOperend = new System.Windows.Forms.Label();
            this.lblSecondOperend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radBtnAdd = new System.Windows.Forms.RadioButton();
            this.radBtnSub = new System.Windows.Forms.RadioButton();
            this.radBtnMulti = new System.Windows.Forms.RadioButton();
            this.radBtnDiv = new System.Windows.Forms.RadioButton();
            this.radBtnRem = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblFirstOperend
            // 
            this.lblFirstOperend.AutoSize = true;
            this.lblFirstOperend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstOperend.Location = new System.Drawing.Point(46, 54);
            this.lblFirstOperend.Name = "lblFirstOperend";
            this.lblFirstOperend.Size = new System.Drawing.Size(133, 25);
            this.lblFirstOperend.TabIndex = 0;
            this.lblFirstOperend.Text = "First Operend";
            this.lblFirstOperend.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSecondOperend
            // 
            this.lblSecondOperend.AutoSize = true;
            this.lblSecondOperend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondOperend.Location = new System.Drawing.Point(238, 54);
            this.lblSecondOperend.Name = "lblSecondOperend";
            this.lblSecondOperend.Size = new System.Drawing.Size(161, 25);
            this.lblSecondOperend.TabIndex = 1;
            this.lblSecondOperend.Text = "Second Operend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpression.Location = new System.Drawing.Point(393, 246);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(108, 25);
            this.lblExpression.TabIndex = 3;
            this.lblExpression.Text = "Expression";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(393, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(610, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 23);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(534, 251);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 23);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(534, 312);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 23);
            this.textBox4.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(52, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 184);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radBtnAdd
            // 
            this.radBtnAdd.AutoSize = true;
            this.radBtnAdd.Location = new System.Drawing.Point(64, 196);
            this.radBtnAdd.Name = "radBtnAdd";
            this.radBtnAdd.Size = new System.Drawing.Size(63, 19);
            this.radBtnAdd.TabIndex = 11;
            this.radBtnAdd.TabStop = true;
            this.radBtnAdd.Text = "Add(+)";
            this.radBtnAdd.UseVisualStyleBackColor = true;
            // 
            // radBtnSub
            // 
            this.radBtnSub.AutoSize = true;
            this.radBtnSub.Location = new System.Drawing.Point(60, 221);
            this.radBtnSub.Name = "radBtnSub";
            this.radBtnSub.Size = new System.Drawing.Size(58, 19);
            this.radBtnSub.TabIndex = 12;
            this.radBtnSub.TabStop = true;
            this.radBtnSub.Text = "Sub(-)";
            this.radBtnSub.UseVisualStyleBackColor = true;
            // 
            // radBtnMulti
            // 
            this.radBtnMulti.AutoSize = true;
            this.radBtnMulti.Location = new System.Drawing.Point(61, 246);
            this.radBtnMulti.Name = "radBtnMulti";
            this.radBtnMulti.Size = new System.Drawing.Size(66, 19);
            this.radBtnMulti.TabIndex = 13;
            this.radBtnMulti.TabStop = true;
            this.radBtnMulti.Text = "Multi(*)";
            this.radBtnMulti.UseVisualStyleBackColor = true;
            // 
            // radBtnDiv
            // 
            this.radBtnDiv.AutoSize = true;
            this.radBtnDiv.Location = new System.Drawing.Point(60, 279);
            this.radBtnDiv.Name = "radBtnDiv";
            this.radBtnDiv.Size = new System.Drawing.Size(55, 19);
            this.radBtnDiv.TabIndex = 14;
            this.radBtnDiv.TabStop = true;
            this.radBtnDiv.Text = "Div(/)";
            this.radBtnDiv.UseVisualStyleBackColor = true;
            // 
            // radBtnRem
            // 
            this.radBtnRem.AutoSize = true;
            this.radBtnRem.Location = new System.Drawing.Point(60, 310);
            this.radBtnRem.Name = "radBtnRem";
            this.radBtnRem.Size = new System.Drawing.Size(67, 19);
            this.radBtnRem.TabIndex = 15;
            this.radBtnRem.TabStop = true;
            this.radBtnRem.Text = "Rem(%)";
            this.radBtnRem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radBtnRem);
            this.Controls.Add(this.radBtnDiv);
            this.Controls.Add(this.radBtnMulti);
            this.Controls.Add(this.radBtnSub);
            this.Controls.Add(this.radBtnAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSecondOperend);
            this.Controls.Add(this.lblFirstOperend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HelpProvider helpProvider1;
        private Label lblFirstOperend;
        private Label lblSecondOperend;
        private Label label3;
        private Label lblExpression;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox listBox1;
        private RadioButton radBtnAdd;
        private RadioButton radBtnSub;
        private RadioButton radBtnMulti;
        private RadioButton radBtnDiv;
        private RadioButton radBtnRem;
    }
}