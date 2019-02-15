namespace StudyMemo2
{
    partial class Todo
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
            this.label1 = new System.Windows.Forms.Label();
            this.recordDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.toDoBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toDoList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doneList = new System.Windows.Forms.ListBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付";
            // 
            // recordDate
            // 
            this.recordDate.Location = new System.Drawing.Point(24, 48);
            this.recordDate.Name = "recordDate";
            this.recordDate.Size = new System.Drawing.Size(200, 19);
            this.recordDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "今日やること";
            // 
            // toDoBox
            // 
            this.toDoBox.FormattingEnabled = true;
            this.toDoBox.Location = new System.Drawing.Point(26, 90);
            this.toDoBox.Name = "toDoBox";
            this.toDoBox.Size = new System.Drawing.Size(121, 20);
            this.toDoBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(153, 88);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "タスク登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "今日やることリスト";
            // 
            // toDoList
            // 
            this.toDoList.FormattingEnabled = true;
            this.toDoList.Location = new System.Drawing.Point(27, 156);
            this.toDoList.Name = "toDoList";
            this.toDoList.Size = new System.Drawing.Size(120, 88);
            this.toDoList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "完了したタスク";
            // 
            // doneList
            // 
            this.doneList.FormattingEnabled = true;
            this.doneList.ItemHeight = 12;
            this.doneList.Location = new System.Drawing.Point(245, 156);
            this.doneList.Name = "doneList";
            this.doneList.Size = new System.Drawing.Size(120, 88);
            this.doneList.TabIndex = 8;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(153, 156);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "完了登録";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneClicked);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(153, 196);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "タスクの削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 298);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.doneList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toDoList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.toDoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordDate);
            this.Controls.Add(this.label1);
            this.Name = "Todo";
            this.Text = "Todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker recordDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox toDoBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox toDoList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox doneList;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button deleteButton;
    }
}