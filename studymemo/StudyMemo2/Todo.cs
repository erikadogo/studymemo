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
    public partial class Todo : Form
    {
        List<string> todoList = new List<string>();
        List<string> doneLists = new List<string>();
        string filePath = @"C:\Users\181016PM\Documents\C#\StudyMemo2\StudyMemo2\text\";

        public Todo()
        {
            InitializeComponent();

            //Listに保存したtodoリスト(登録用)を呼び出す
            foreach (string todo in todoList)
            {
                toDoBox.Items.Add(todo);
            }
            //日付によってdoneListの表示内容を変える
            //doneListの呼び出し
            ForReadToDo();
            foreach (var item in doneLists)
            {
                this.doneList.Items.Add(item);
            }
            
        }

        private void AddClicked(object sender, EventArgs e)
        {
            this.toDoList.Items.Add(this.toDoBox.Text);
            toDoBox.Text = "";
        }

        private void DoneClicked(object sender, EventArgs e)
        {
            List<string> todos = new List<string>();
            

            foreach (string item in this.toDoList.CheckedItems)
            {
                todos.Add(item);
            }

            //todaystodo.txtへの書き込み
            ForTodaysToDo(todos);

            foreach (string item in todos)
            {
                //リストへ追加＆削除
                this.doneList.Items.Add(item);
                this.toDoList.Items.Remove(item);
            }
        }
        
        //todaystodoの読み込み
        private void ForReadToDo()
        {
            var filePath1 = filePath + "todaystodo.txt";
            var lines = File.ReadAllLines(filePath1, Encoding.UTF8);

            foreach(var line in lines)
            {
                doneLists.Add(line);
            }
        }

        //todaystodoへの書き込み
        private void ForTodaysToDo(List<string> items)
        {
            var filePath2 = filePath + "todaystodo.txt";
            
            //ファイル末尾へ書き込み
            using (var writer = new StreamWriter(filePath2, append: true))
            {
                writer.Write(this.recordDate.Value + ",");

                for (int i = 0; i < items.Count; i++)
                {
                    if((i-1) == items.Count)
                    {
                        writer.WriteLine(items[i]);
                    }
                    else
                    {
                        writer.Write(items[i] + ",");
                    }
                }
            }
        }
    }
}
