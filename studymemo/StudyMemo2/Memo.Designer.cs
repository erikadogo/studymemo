namespace StudyMemo2
{
    partial class Memo
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
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.memoTitle = new System.Windows.Forms.TextBox();
            this.memoBox = new System.Windows.Forms.TextBox();
            this.recordMemo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(32, 29);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 19);
            this.dateTime.TabIndex = 0;
            // 
            // memoTitle
            // 
            this.memoTitle.Location = new System.Drawing.Point(32, 81);
            this.memoTitle.Name = "memoTitle";
            this.memoTitle.Size = new System.Drawing.Size(302, 19);
            this.memoTitle.TabIndex = 1;
            // 
            // memoBox
            // 
            this.memoBox.Location = new System.Drawing.Point(32, 146);
            this.memoBox.Multiline = true;
            this.memoBox.Name = "memoBox";
            this.memoBox.Size = new System.Drawing.Size(302, 106);
            this.memoBox.TabIndex = 2;
            // 
            // recordMemo
            // 
            this.recordMemo.Location = new System.Drawing.Point(32, 272);
            this.recordMemo.Name = "recordMemo";
            this.recordMemo.Size = new System.Drawing.Size(108, 48);
            this.recordMemo.TabIndex = 3;
            this.recordMemo.Text = "登録";
            this.recordMemo.UseVisualStyleBackColor = true;
            this.recordMemo.Click += new System.EventHandler(this.RecordMemoClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "メモタイトル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "メモ本文";
            // 
            // Memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recordMemo);
            this.Controls.Add(this.memoBox);
            this.Controls.Add(this.memoTitle);
            this.Controls.Add(this.dateTime);
            this.Name = "Memo";
            this.Text = "Memo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox memoTitle;
        private System.Windows.Forms.TextBox memoBox;
        private System.Windows.Forms.Button recordMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}