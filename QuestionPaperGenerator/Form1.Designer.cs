namespace QuestionPaperGenerator
{
    partial class Demo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChapterNo = new System.Windows.Forms.TextBox();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbMarks = new System.Windows.Forms.TextBox();
            this.tbPriority = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chapter No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marks";
            // 
            // tbChapterNo
            // 
            this.tbChapterNo.Location = new System.Drawing.Point(113, 19);
            this.tbChapterNo.Name = "tbChapterNo";
            this.tbChapterNo.Size = new System.Drawing.Size(100, 20);
            this.tbChapterNo.TabIndex = 6;
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(113, 97);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(281, 20);
            this.tbQuestion.TabIndex = 7;
            // 
            // tbMarks
            // 
            this.tbMarks.Location = new System.Drawing.Point(113, 177);
            this.tbMarks.Name = "tbMarks";
            this.tbMarks.Size = new System.Drawing.Size(100, 20);
            this.tbMarks.TabIndex = 8;
            // 
            // tbPriority
            // 
            this.tbPriority.Location = new System.Drawing.Point(113, 258);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(100, 20);
            this.tbPriority.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(261, 46);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(116, 20);
            this.tbId.TabIndex = 11;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 312);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbPriority);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMarks);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.tbChapterNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Demo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbChapterNo;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbMarks;
        private System.Windows.Forms.TextBox tbPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbId;
    }
}

