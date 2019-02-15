using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyMemo2
{
    public partial class BookRecord : Form
    {
        string filepath = @"StudyMemo2\text\";
        List<string> booksList = new List<string>();
        List<string> bookTitles = new List<string>();

        public BookRecord()
        {
            InitializeComponent();
            ReadBookList();
            
        }

        private void SearchClicked(object sender, EventArgs e)
        {
            string number = this.isbnBox.Text;
            string url = "https://www.googleapis.com/books/v1/volumes?q=isbn:" + number;
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;
            string title = "";
            string bookImg = "";
            long pages = 0;
            string published = "";

            List<string> authors = new List<string>();
            List<string> categoryList = new List<string>();
            List<JValue> values = new List<JValue>();
            List<JValue> categories = new List<JValue>();

            JObject jres = JObject.Parse(result);
            JArray jarr = (JArray)jres["items"];
            if (jarr == null)
            {
                Console.WriteLine("本のデータがありませんでした");
            }
            else
            {
                foreach (JObject jobj in jarr)
                {
                    JObject jobj2 = (JObject)jobj["volumeInfo"];
                    //本のタイトル
                    JValue titleValue = (JValue)jobj2["title"];
                    //著者名
                    JArray authorArray = (JArray)jobj2["authors"];
                    for (int i = 0; i < authorArray.Count; i++)
                    {
                        values.Add((JValue)authorArray[i]);
                    }
                    for (int i = 0; i < values.Count; i++)
                    {
                        authors.Add((string)values[i].Value);
                        Console.WriteLine(authors[i]);
                    }
                    //出版日
                    JValue publishDate = (JValue)jobj2["publishedDate"];
                    //本のページ数
                    JValue pageCounts = (JValue)jobj2["pageCount"];
                    //本のカテゴリー
                    if (jobj2.ContainsKey("categories"))
                    {
                        JArray categoriesArray = (JArray)jobj2["categories"];
                        for (int i = 0; i < categoriesArray.Count; i++)
                        {
                            categories.Add((JValue)categoriesArray[i]);
                        }
                        for (int i = 0; i < categories.Count; i++)
                        {
                            categoryList.Add((string)categories[i].Value);
                        }
                    }
                    else
                    {
                        categoryList.Add("nothing");
                    }

                    //本の表紙イメージURL
                    JObject iLinks = (JObject)jobj2["imageLinks"];
                    JValue link = (JValue)iLinks["smallThumbnail"];

                    //string変数にjsonの結果を入れる
                    title = (string)titleValue.Value;
                    published = (string)publishDate.Value;
                    pages = (long)pageCounts.Value;
                    bookImg = (string)link.Value;
                    string results = "";
                    string results2 = "";
                    int count = 0;
                    int count2 = 0;
                    
                    //著者が複数人いることもあるのでリストにいれて
                    //その値をstring+stringというように一つの文字列になおしてます
                    foreach (var item in authors)
                    {
                        count++;

                        if (count == authors.Count)
                        {
                            results += item;
                        }
                        else
                        {
                            results = results + item + "、";
                        }
                        
                    }
                    foreach (var item in categoryList)
                    {
                        count2++;
                        if (count == categoryList.Count)
                        {
                            results2 += item;
                        }
                        else
                        {
                            results2 = results2 + item + "、";
                        }
                    }

                    //変数の値を各ツールボックスへ渡す
                    titleBox.Text = title;
                    authorBox.Text = results;
                    publishedBox.Text = published;
                    pageBox.Text = pages.ToString();
                    categoryBox.Text = results2;
                    pictureBox.ImageLocation = bookImg;
                }
            }

            
        }

        private void AddBookClicked(object sender, EventArgs e)
        {
            DateTime td = DateTime.Today;
            string today = td.ToString();
            List<string> bookDataList = new List<string>();
            bookDataList.Add(this.titleBox.Text);
            bookDataList.Add(this.authorBox.Text);
            bookDataList.Add(this.publishedBox.Text);
            bookDataList.Add(this.pageBox.Text);
            bookDataList.Add(this.categoryBox.Text);

            bookData.DataTable1.AddDataTable1Row(
                today,
                this.titleBox.Text,
                this.authorBox.Text,
                this.publishedBox.Text,
                this.pageBox.Text,
                this.categoryBox.Text
                );

            AddBookList(bookDataList);

        }

        private void ReadMemoClicked(object sender, EventArgs e)
        {
            string addTitle = this.bookTitle.Text;
            string addPages = this.readPages.Text;
            string addMemo = this.readMemo.Text;
            DateTime td = DateTime.Today;
            string today = td.ToString();

            var filePath = @"StudyMemo2\text\books\";  
            StreamWriter sw = File.CreateText(filePath + addTitle + ".txt");
            sw.WriteLine(today+","+addTitle+","+addPages+","+addMemo);
            sw.Close();


        }

        private void ReadBookList()
        {
            var filePath = @"StudyMemo2\text\books.txt"; //filepath + "books.txt"
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath,Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        string[] data = line.Split(',');
                        bookData.DataTable1.AddDataTable1Row(
                            data[0],data[1],data[2],data[3],data[4],data[5]
                            );
                    }
                }
            }

        }

        private void AddBookList(List<string> bookDataList)
        {
            DateTime td = DateTime.Today;
            string today = td.ToString();
            var filePath = @"StudyMemo2\text\books.txt";  //filepath + "books.txt";

            using (var writer = new StreamWriter(filePath,append:true))
            {
                writer.Write(today + ",");

                for (int i = 0; i < bookDataList.Count; i++)
                {
                    if ((i - 1) == bookDataList.Count)
                    {
                        writer.WriteLine(bookDataList[i]);
                    }
                    else
                    {
                        writer.Write(bookDataList[i] + ",");
                    }
                }
            }
        }
    }
}
