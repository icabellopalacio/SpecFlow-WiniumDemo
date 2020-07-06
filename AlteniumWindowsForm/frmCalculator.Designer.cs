namespace AlteniumWindowsForm
{
    partial class frmCalculator
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
            this.txtOperator1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOperator2 = new System.Windows.Forms.Label();
            this.lblOperator1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtOperator2 = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperator1
            // 
            this.txtOperator1.Location = new System.Drawing.Point(117, 99);
            this.txtOperator1.Name = "txtOperator1";
            this.txtOperator1.Size = new System.Drawing.Size(381, 26);
            this.txtOperator1.TabIndex = 22;
            this.txtOperator1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperator1_KeyPress);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(113, 316);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 20;
            this.lblResult.Text = "Result";
            // 
            // lblOperator2
            // 
            this.lblOperator2.AutoSize = true;
            this.lblOperator2.Location = new System.Drawing.Point(113, 163);
            this.lblOperator2.Name = "lblOperator2";
            this.lblOperator2.Size = new System.Drawing.Size(85, 20);
            this.lblOperator2.TabIndex = 19;
            this.lblOperator2.Text = "Operator 2";
            // 
            // lblOperator1
            // 
            this.lblOperator1.AutoSize = true;
            this.lblOperator1.Location = new System.Drawing.Point(113, 66);
            this.lblOperator1.Name = "lblOperator1";
            this.lblOperator1.Size = new System.Drawing.Size(85, 20);
            this.lblOperator1.TabIndex = 18;
            this.lblOperator1.Text = "Operator 1";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtResult.Location = new System.Drawing.Point(117, 353);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(381, 26);
            this.txtResult.TabIndex = 17;
            // 
            // txtOperator2
            // 
            this.txtOperator2.Location = new System.Drawing.Point(117, 195);
            this.txtOperator2.Name = "txtOperator2";
            this.txtOperator2.Size = new System.Drawing.Size(381, 26);
            this.txtOperator2.TabIndex = 16;
            this.txtOperator2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperator2_KeyPress);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(548, 220);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(140, 35);
            this.btnMultiply.TabIndex = 14;
            this.btnMultiply.Text = "MULTIPLY";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(548, 163);
            this.btnSubstract.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(140, 35);
            this.btnSubstract.TabIndex = 13;
            this.btnSubstract.Text = "SUBSTRACT";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(548, 282);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(140, 35);
            this.btnDivide.TabIndex = 23;
            this.btnDivide.Text = "DIVIDE";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(548, 99);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 35);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(548, 344);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 35);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.txtOperator1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperator2);
            this.Controls.Add(this.lblOperator1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperator2);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altium";
            this.Load += new System.EventHandler(this.frmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperator1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOperator2;
        private System.Windows.Forms.Label lblOperator1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtOperator2;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}