namespace WinFormUI
{
    partial class Dashboard
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
            this.btExit = new System.Windows.Forms.Button();
            this.btResetTestCase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpectedResult = new System.Windows.Forms.TextBox();
            this.txtBxTestingResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBxTestingResultMatch = new System.Windows.Forms.CheckBox();
            this.btRunTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rTxtBxTestData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(671, 536);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(191, 59);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btResetTestCase
            // 
            this.btResetTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetTestCase.Location = new System.Drawing.Point(439, 536);
            this.btResetTestCase.Name = "btResetTestCase";
            this.btResetTestCase.Size = new System.Drawing.Size(188, 59);
            this.btResetTestCase.TabIndex = 7;
            this.btResetTestCase.Text = "Rest Test Case";
            this.btResetTestCase.UseVisualStyleBackColor = true;
            this.btResetTestCase.Click += new System.EventHandler(this.btResetTestCase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input UnitTest Data";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Expected Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtExpectedResult
            // 
            this.txtExpectedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpectedResult.Location = new System.Drawing.Point(193, 407);
            this.txtExpectedResult.Name = "txtExpectedResult";
            this.txtExpectedResult.Size = new System.Drawing.Size(681, 30);
            this.txtExpectedResult.TabIndex = 12;
            // 
            // txtBxTestingResult
            // 
            this.txtBxTestingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTestingResult.Location = new System.Drawing.Point(193, 484);
            this.txtBxTestingResult.Name = "txtBxTestingResult";
            this.txtBxTestingResult.Size = new System.Drawing.Size(681, 30);
            this.txtBxTestingResult.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Testing Result";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBxTestingResultMatch
            // 
            this.cBxTestingResultMatch.AutoSize = true;
            this.cBxTestingResultMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxTestingResultMatch.Location = new System.Drawing.Point(315, 448);
            this.cBxTestingResultMatch.Name = "cBxTestingResultMatch";
            this.cBxTestingResultMatch.Size = new System.Drawing.Size(380, 29);
            this.cBxTestingResultMatch.TabIndex = 12;
            this.cBxTestingResultMatch.Text = "Testing Result Matched with Expected?";
            this.cBxTestingResultMatch.UseVisualStyleBackColor = true;
            this.cBxTestingResultMatch.Visible = false;
            // 
            // btRunTest
            // 
            this.btRunTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRunTest.Location = new System.Drawing.Point(204, 536);
            this.btRunTest.Name = "btRunTest";
            this.btRunTest.Size = new System.Drawing.Size(188, 59);
            this.btRunTest.TabIndex = 15;
            this.btRunTest.Text = "Run Test Case";
            this.btRunTest.UseVisualStyleBackColor = true;
            this.btRunTest.Click += new System.EventHandler(this.btRunTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "The Longest Increasing Subsequence Unit Testing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTxtBxTestData
            // 
            this.rTxtBxTestData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtBxTestData.Location = new System.Drawing.Point(192, 86);
            this.rTxtBxTestData.Name = "rTxtBxTestData";
            this.rTxtBxTestData.Size = new System.Drawing.Size(693, 307);
            this.rTxtBxTestData.TabIndex = 18;
            this.rTxtBxTestData.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 629);
            this.Controls.Add(this.rTxtBxTestData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRunTest);
            this.Controls.Add(this.cBxTestingResultMatch);
            this.Controls.Add(this.txtBxTestingResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExpectedResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btResetTestCase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnitTest Demo by David";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btResetTestCase;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpectedResult;
        private System.Windows.Forms.TextBox txtBxTestingResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBxTestingResultMatch;
        private System.Windows.Forms.Button btRunTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTxtBxTestData;
    }
}

