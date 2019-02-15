namespace StudyMemo2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openButton = new System.Windows.Forms.Button();
            this.todoButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.memoButton = new System.Windows.Forms.Button();
            this.tweetButton = new System.Windows.Forms.Button();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.メモタイトルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.メモ本文DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.完了タスクDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.読書記録DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyRecord = new StudyMemo2.studyRecord();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "学習記録一覧";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.日数DataGridViewTextBoxColumn,
            this.メモタイトルDataGridViewTextBoxColumn,
            this.メモ本文DataGridViewTextBoxColumn,
            this.完了タスクDataGridViewTextBoxColumn,
            this.読書記録DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(572, 179);
            this.dataGridView1.TabIndex = 1;
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openButton.Location = new System.Drawing.Point(630, 129);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(110, 86);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "開く";
            this.openButton.UseVisualStyleBackColor = true;
            // 
            // todoButton
            // 
            this.todoButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.todoButton.Location = new System.Drawing.Point(33, 234);
            this.todoButton.Name = "todoButton";
            this.todoButton.Size = new System.Drawing.Size(98, 35);
            this.todoButton.TabIndex = 3;
            this.todoButton.Text = "todo";
            this.todoButton.UseVisualStyleBackColor = true;
            this.todoButton.Click += new System.EventHandler(this.ToDoClicked);
            // 
            // booksButton
            // 
            this.booksButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.booksButton.Location = new System.Drawing.Point(156, 234);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(98, 35);
            this.booksButton.TabIndex = 4;
            this.booksButton.Text = "書籍管理";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.ToBookClicked);
            // 
            // memoButton
            // 
            this.memoButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memoButton.Location = new System.Drawing.Point(276, 234);
            this.memoButton.Name = "memoButton";
            this.memoButton.Size = new System.Drawing.Size(98, 35);
            this.memoButton.TabIndex = 5;
            this.memoButton.Text = "メモ";
            this.memoButton.UseVisualStyleBackColor = true;
            this.memoButton.Click += new System.EventHandler(this.MemoClicked);
            // 
            // tweetButton
            // 
            this.tweetButton.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tweetButton.Location = new System.Drawing.Point(403, 234);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(94, 35);
            this.tweetButton.TabIndex = 6;
            this.tweetButton.Text = "ツイート";
            this.tweetButton.UseVisualStyleBackColor = true;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            // 
            // 日数DataGridViewTextBoxColumn
            // 
            this.日数DataGridViewTextBoxColumn.DataPropertyName = "日数";
            this.日数DataGridViewTextBoxColumn.HeaderText = "日数";
            this.日数DataGridViewTextBoxColumn.Name = "日数DataGridViewTextBoxColumn";
            // 
            // メモタイトルDataGridViewTextBoxColumn
            // 
            this.メモタイトルDataGridViewTextBoxColumn.DataPropertyName = "メモタイトル";
            this.メモタイトルDataGridViewTextBoxColumn.HeaderText = "メモタイトル";
            this.メモタイトルDataGridViewTextBoxColumn.Name = "メモタイトルDataGridViewTextBoxColumn";
            // 
            // メモ本文DataGridViewTextBoxColumn
            // 
            this.メモ本文DataGridViewTextBoxColumn.DataPropertyName = "メモ本文";
            this.メモ本文DataGridViewTextBoxColumn.HeaderText = "メモ本文";
            this.メモ本文DataGridViewTextBoxColumn.Name = "メモ本文DataGridViewTextBoxColumn";
            // 
            // 完了タスクDataGridViewTextBoxColumn
            // 
            this.完了タスクDataGridViewTextBoxColumn.DataPropertyName = "完了タスク";
            this.完了タスクDataGridViewTextBoxColumn.HeaderText = "完了タスク";
            this.完了タスクDataGridViewTextBoxColumn.Name = "完了タスクDataGridViewTextBoxColumn";
            // 
            // 読書記録DataGridViewTextBoxColumn
            // 
            this.読書記録DataGridViewTextBoxColumn.DataPropertyName = "読書記録";
            this.読書記録DataGridViewTextBoxColumn.HeaderText = "読書記録";
            this.読書記録DataGridViewTextBoxColumn.Name = "読書記録DataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.studyRecord;
            // 
            // studyRecord
            // 
            this.studyRecord.DataSetName = "studyRecord";
            this.studyRecord.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(752, 348);
            this.Controls.Add(this.tweetButton);
            this.Controls.Add(this.memoButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.todoButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button todoButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button memoButton;
        private System.Windows.Forms.Button tweetButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn メモタイトルDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn メモ本文DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 完了タスクDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 読書記録DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private studyRecord studyRecord;
    }
}

