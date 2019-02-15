using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyMemo2
{
    public partial class Form1 : Form
    {
        Todo todo;
        BookRecord bookrecord;
        Memo memo;

        public Form1()
        {
            InitializeComponent();
            ReadData();

        }

        private void ToDoClicked(object sender, EventArgs e)
        {
            this.todo = new Todo();
            todo.Show();
        }

        private void ToBookClicked(object sender, EventArgs e)
        {
            this.bookrecord = new BookRecord();
            bookrecord.Show();
        }

        private void MemoClicked(object sender, EventArgs e)
        {
            this.memo = new Memo();
            memo.Show();
        }

        private void ReadData()
        {
            var filePath = @"\\192.168.0.198\homes\ErikaG\Drive\C#\発表用\studymemo\StudyMemo2\text\viewdata.txt"; //filepath + "viewdata.txt"

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] data = line.Split(',');
                        studyRecord.DataTable1.AddDataTable1Row(
                            data[0], data[1], data[2], data[3], data[4], data[5]
                            );
                    }
                }
            }
        }

        private void ReadAll()
        {
            var filePath = @"\\192.168.0.198\homes\ErikaG\Drive\C#\発表用\studymemo\StudyMemo2\text\";
            
        }
    }
}
