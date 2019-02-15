namespace StudyMemo2
{
    partial class BookRecord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bookDataView = new System.Windows.Forms.DataGridView();
            this.登録日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.書籍タイトルDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.著者名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.総ページ数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.カテゴリDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookData = new StudyMemo2.BookData();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnBox = new System.Windows.Forms.MaskedTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.publishedBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pageBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.recordReadDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.readPages = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.readMemo = new System.Windows.Forms.TextBox();
            this.readMemoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "書籍情報";
            // 
            // bookDataView
            // 
            this.bookDataView.AutoGenerateColumns = false;
            this.bookDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.登録日DataGridViewTextBoxColumn,
            this.書籍タイトルDataGridViewTextBoxColumn,
            this.著者名DataGridViewTextBoxColumn,
            this.出版日DataGridViewTextBoxColumn,
            this.総ページ数DataGridViewTextBoxColumn,
            this.カテゴリDataGridViewTextBoxColumn});
            this.bookDataView.DataSource = this.dataTable1BindingSource;
            this.bookDataView.Location = new System.Drawing.Point(27, 37);
            this.bookDataView.Name = "bookDataView";
            this.bookDataView.RowTemplate.Height = 21;
            this.bookDataView.Size = new System.Drawing.Size(302, 150);
            this.bookDataView.TabIndex = 1;
            // 
            // 登録日DataGridViewTextBoxColumn
            // 
            this.登録日DataGridViewTextBoxColumn.DataPropertyName = "登録日";
            this.登録日DataGridViewTextBoxColumn.HeaderText = "登録日";
            this.登録日DataGridViewTextBoxColumn.Name = "登録日DataGridViewTextBoxColumn";
            // 
            // 書籍タイトルDataGridViewTextBoxColumn
            // 
            this.書籍タイトルDataGridViewTextBoxColumn.DataPropertyName = "書籍タイトル";
            this.書籍タイトルDataGridViewTextBoxColumn.HeaderText = "書籍タイトル";
            this.書籍タイトルDataGridViewTextBoxColumn.Name = "書籍タイトルDataGridViewTextBoxColumn";
            // 
            // 著者名DataGridViewTextBoxColumn
            // 
            this.著者名DataGridViewTextBoxColumn.DataPropertyName = "著者名";
            this.著者名DataGridViewTextBoxColumn.HeaderText = "著者名";
            this.著者名DataGridViewTextBoxColumn.Name = "著者名DataGridViewTextBoxColumn";
            // 
            // 出版日DataGridViewTextBoxColumn
            // 
            this.出版日DataGridViewTextBoxColumn.DataPropertyName = "出版日";
            this.出版日DataGridViewTextBoxColumn.HeaderText = "出版日";
            this.出版日DataGridViewTextBoxColumn.Name = "出版日DataGridViewTextBoxColumn";
            // 
            // 総ページ数DataGridViewTextBoxColumn
            // 
            this.総ページ数DataGridViewTextBoxColumn.DataPropertyName = "総ページ数";
            this.総ページ数DataGridViewTextBoxColumn.HeaderText = "総ページ数";
            this.総ページ数DataGridViewTextBoxColumn.Name = "総ページ数DataGridViewTextBoxColumn";
            // 
            // カテゴリDataGridViewTextBoxColumn
            // 
            this.カテゴリDataGridViewTextBoxColumn.DataPropertyName = "カテゴリ";
            this.カテゴリDataGridViewTextBoxColumn.HeaderText = "カテゴリ";
            this.カテゴリDataGridViewTextBoxColumn.Name = "カテゴリDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.bookData;
            // 
            // bookData
            // 
            this.bookData.DataSetName = "BookData";
            this.bookData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBNを入力";
            // 
            // isbnBox
            // 
            this.isbnBox.Location = new System.Drawing.Point(408, 39);
            this.isbnBox.Mask = "0000000000000";
            this.isbnBox.Name = "isbnBox";
            this.isbnBox.Size = new System.Drawing.Size(100, 19);
            this.isbnBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(523, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "タイトル";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(354, 85);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 19);
            this.titleBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "著者名";
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(354, 120);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(100, 19);
            this.authorBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "出版日";
            // 
            // publishedBox
            // 
            this.publishedBox.Location = new System.Drawing.Point(354, 155);
            this.publishedBox.Name = "publishedBox";
            this.publishedBox.Size = new System.Drawing.Size(100, 19);
            this.publishedBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "ページ数";
            // 
            // pageBox
            // 
            this.pageBox.Location = new System.Drawing.Point(354, 194);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(100, 19);
            this.pageBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "カテゴリー";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(354, 232);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(100, 19);
            this.categoryBox.TabIndex = 14;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(476, 81);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(123, 148);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "読書記録";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "日付";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(523, 247);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 18;
            this.addBookButton.Text = "蔵書登録";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.AddBookClicked);
            // 
            // recordReadDate
            // 
            this.recordReadDate.Location = new System.Drawing.Point(102, 221);
            this.recordReadDate.Name = "recordReadDate";
            this.recordReadDate.Size = new System.Drawing.Size(200, 19);
            this.recordReadDate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "タイトル";
            // 
            // bookTitle
            // 
            this.bookTitle.FormattingEnabled = true;
            this.bookTitle.Location = new System.Drawing.Point(102, 246);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(121, 20);
            this.bookTitle.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "読了ページ数";
            // 
            // readPages
            // 
            this.readPages.Location = new System.Drawing.Point(102, 272);
            this.readPages.Name = "readPages";
            this.readPages.Size = new System.Drawing.Size(100, 19);
            this.readPages.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "メモ";
            // 
            // readMemo
            // 
            this.readMemo.Location = new System.Drawing.Point(102, 296);
            this.readMemo.Multiline = true;
            this.readMemo.Name = "readMemo";
            this.readMemo.Size = new System.Drawing.Size(181, 61);
            this.readMemo.TabIndex = 25;
            // 
            // readMemoButton
            // 
            this.readMemoButton.Location = new System.Drawing.Point(304, 311);
            this.readMemoButton.Name = "readMemoButton";
            this.readMemoButton.Size = new System.Drawing.Size(88, 46);
            this.readMemoButton.TabIndex = 26;
            this.readMemoButton.Text = "読書メモ登録";
            this.readMemoButton.UseVisualStyleBackColor = true;
            this.readMemoButton.Click += new System.EventHandler(this.ReadMemoClicked);
            // 
            // BookRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 376);
            this.Controls.Add(this.readMemoButton);
            this.Controls.Add(this.readMemo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.readPages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.recordReadDate);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pageBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.publishedBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookDataView);
            this.Controls.Add(this.label1);
            this.Name = "BookRecord";
            this.Text = "BookRecord";
            ((System.ComponentModel.ISupportInitialize)(this.bookDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookDataView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox isbnBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox publishedBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.DateTimePicker recordReadDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox bookTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox readPages;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox readMemo;
        private System.Windows.Forms.Button readMemoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登録日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 書籍タイトルDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 著者名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版日DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 総ページ数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn カテゴリDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private BookData bookData;
    }
}