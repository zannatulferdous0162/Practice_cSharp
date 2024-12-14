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
            this.btnCalculate = new System.Windows.Forms.Label();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxFirstOperend = new System.Windows.Forms.TextBox();
            this.textBoxSecondOperend = new System.Windows.Forms.TextBox();
            this.txtBoxExpression = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.listBoxButton = new System.Windows.Forms.ListBox();
            this.radBtnSub = new System.Windows.Forms.RadioButton();
            this.radBtnMulti = new System.Windows.Forms.RadioButton();
            this.radBtnDiv = new System.Windows.Forms.RadioButton();
            this.radBtnRem = new System.Windows.Forms.RadioButton();
            this.radBtnAdd = new System.Windows.Forms.RadioButton();
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
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(52, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(92, 25);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(393, 310);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(66, 25);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(610, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxFirstOperend
            // 
            this.textBoxFirstOperend.Location = new System.Drawing.Point(46, 104);
            this.textBoxFirstOperend.Name = "textBoxFirstOperend";
            this.textBoxFirstOperend.Size = new System.Drawing.Size(141, 23);
            this.textBoxFirstOperend.TabIndex = 6;
            // 
            // textBoxSecondOperend
            // 
            this.textBoxSecondOperend.Location = new System.Drawing.Point(238, 104);
            this.textBoxSecondOperend.Name = "textBoxSecondOperend";
            this.textBoxSecondOperend.Size = new System.Drawing.Size(141, 23);
            this.textBoxSecondOperend.TabIndex = 7;
            // 
            // txtBoxExpression
            // 
            this.txtBoxExpression.Location = new System.Drawing.Point(534, 251);
            this.txtBoxExpression.Name = "txtBoxExpression";
            this.txtBoxExpression.Size = new System.Drawing.Size(141, 23);
            this.txtBoxExpression.TabIndex = 8;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(534, 312);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(141, 23);
            this.txtBoxResult.TabIndex = 9;
            // 
            // listBoxButton
            // 
            this.listBoxButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxButton.FormattingEnabled = true;
            this.listBoxButton.ItemHeight = 21;
            this.listBoxButton.Location = new System.Drawing.Point(52, 155);
            this.listBoxButton.Name = "listBoxButton";
            this.listBoxButton.Size = new System.Drawing.Size(177, 172);
            this.listBoxButton.TabIndex = 10;
            this.listBoxButton.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radBtnSub
            // 
            this.radBtnSub.AutoSize = true;
            this.radBtnSub.Location = new System.Drawing.Point(70, 205);
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
            this.radBtnMulti.Location = new System.Drawing.Point(70, 230);
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
            this.radBtnDiv.Location = new System.Drawing.Point(70, 255);
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
            this.radBtnRem.Location = new System.Drawing.Point(70, 280);
            this.radBtnRem.Name = "radBtnRem";
            this.radBtnRem.Size = new System.Drawing.Size(67, 19);
            this.radBtnRem.TabIndex = 15;
            this.radBtnRem.TabStop = true;
            this.radBtnRem.Text = "Rem(%)";
            this.radBtnRem.UseVisualStyleBackColor = true;
            // 
            // radBtnAdd
            // 
            this.radBtnAdd.AutoSize = true;
            this.radBtnAdd.Location = new System.Drawing.Point(70, 180);
            this.radBtnAdd.Name = "radBtnAdd";
            this.radBtnAdd.Size = new System.Drawing.Size(63, 19);
            this.radBtnAdd.TabIndex = 11;
            this.radBtnAdd.TabStop = true;
            this.radBtnAdd.Text = "Add(+)";
            this.radBtnAdd.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.listBoxButton);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxExpression);
            this.Controls.Add(this.textBoxSecondOperend);
            this.Controls.Add(this.textBoxFirstOperend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblSecondOperend);
            this.Controls.Add(this.lblFirstOperend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HelpProvider helpProvider1;
        private Label lblFirstOperend;
        private Label lblSecondOperend;
        private Label btnCalculate;
        private Label lblExpression;
        private Label lblResult;
        private Button btnExit;
        private TextBox textBoxFirstOperend;
        private TextBox textBoxSecondOperend;
        private TextBox txtBoxExpression;
        private TextBox txtBoxResult;
        private ListBox listBoxButton;
        private RadioButton radBtnSub;
        private RadioButton radBtnMulti;
        private RadioButton radBtnDiv;
        private RadioButton radBtnRem;
        private RadioButton radBtnAdd;
    }
}