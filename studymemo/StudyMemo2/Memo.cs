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
    public partial class Memo : Form
    {
        public Memo()
        {
            InitializeComponent();
        }

        private void RecordMemoClicked(object sender, EventArgs e)
        {
            string date = dateTime.Text;
            string studyTitle = memoTitle.Text;
            string studyMemo = memoBox.Text;
            var filePath = @"\\192.168.0.198\homes\ErikaG\Drive\C#\発表用\studymemo\StudyMemo2\text\books\";

            //UTF-8でファイルを作成
            //System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\181016PM\document\"+studyTitle+".txt", true,
            //System.Text.Encoding.GetEncoding("utf-8"));

            StreamWriter sw = File.CreateText(filePath + studyTitle + ".txt");

            //書き込み
            sw.WriteLine(date+","+studyTitle+","+studyMemo);

            //ストリームを閉じる
            sw.Close();

        }
    }
}
