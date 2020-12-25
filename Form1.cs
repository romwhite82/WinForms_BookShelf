using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//путь к Документам
        
        //string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        ListViewItem[] backupLvBuy;
        ListViewItem[] backupLvRead;

        class MyBooks
        {
            public string Author { get;  } 
            public string Name { get;  } 
            public string Year { get;  } 

            public MyBooks (string Au, string N, string Yr)
            {
                Author = Au;
                Name = N;
                Year = Yr;
            }

            public override string ToString()
            {
                string result = Author + Name + Year;
                return result;
            }
        }

        void func(string Author, string Name, string Year)
        {
            MyBooks newBook = new MyBooks(Author, Name, Year);
            ListViewItem bookItem = new ListViewItem(newBook.Author);
            bookItem.SubItems.Add(newBook.Name);
            bookItem.SubItems.Add(newBook.Year);
            lvBuy.Items.Add(bookItem);
        }

        void InactiveAdd()
        {
            btnAddBook.Enabled = false; 
        }

        void ActiveAdd()
        {
            btnAddBook.Enabled = true;
        }
                               
       public form1() //Это конструктор класса формы
        {
            InitializeComponent();
            MyFunction.InactHandler = new MyFunction.InactAdd(InactiveAdd);
            MyFunction.ActHandler = new MyFunction.ActAdd(ActiveAdd);
            MyFunction.AddBookHandl = new MyFunction.AddBookHandler(func);
            
            lvBuy.SelectedIndexChanged += (s, a) => {
                if (lvBuy.SelectedItems.Count == 1)
                    btnOne.Enabled = true;
                else if (lvBuy.SelectedItems.Count > 1)
                {
                    btnOne.Enabled = false;
                    btnSome.Enabled = true;
                }
                else
                {
                    btnSome.Enabled = false;
                    btnOne.Enabled = false;
                }

            };

            try
            {
                string[] lvBuyInit = File.ReadAllLines($"{path}\\books.dat");

                foreach (string str in lvBuyInit)
                {
                    char[] separator = new char[] { '$', '$' };
                    string[] str_format = str.Split(separator);
                    ListViewItem item_to_add = new ListViewItem();
                    
                    if (str_format[0]=="1")
                    {
                        item_to_add.Text = str_format[2];
                        item_to_add.SubItems.Add(str_format[4]);
                        item_to_add.SubItems.Add(str_format[6]);
                        lvBuy.Items.Add(item_to_add);
                    }
                    else if(str_format[0]=="2")
                    {
                        item_to_add.Text = $"{str_format[2]}";
                        lvRead.Items.Add(item_to_add);
                    }
                    
                }
            }
            catch { }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
               
        private void btnOne_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection SelectedBooks = lvBuy.SelectedItems;
            string BookToAdd = "";
            BookToAdd = SelectedBooks[0].SubItems[0].Text + " - " + SelectedBooks[0].SubItems[1].Text;
            
            ListViewItem itemToFind = lvRead.FindItemWithText(BookToAdd);

            if (itemToFind == null) lvRead.Items.Add(BookToAdd);
        }

        private void btnSome_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection SelectedBooks = this.lvBuy.SelectedItems;
            string BookToAdd = "";

            foreach (ListViewItem i in SelectedBooks)
            {
                BookToAdd = i.SubItems[0].Text + " - " + i.SubItems[1].Text;
                ListViewItem itemToFind = lvRead.FindItemWithText(BookToAdd);
                if (itemToFind == null) lvRead.Items.Add(BookToAdd);
            }

            
        }
                
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            ListView.SelectedIndexCollection indexInBuy = this.lvBuy.SelectedIndices;
            ListView.SelectedIndexCollection indexInRead = this.lvRead.SelectedIndices;

            if (indexInBuy != null)
            {
                for (int i = indexInBuy.Count-1; i >=0; i-- )
                {
                    int j = indexInBuy[i];
                    this.lvBuy.Items.Remove(lvBuy.Items[j]);
                }
            }

            if (indexInRead != null)
            {
                for (int i = indexInRead.Count-1; i >= 0; i--)
                {
                    int j = indexInRead[i];
                    this.lvRead.Items.Remove(lvRead.Items[j]);
                }
            }
        }

        private void btnSaveState_Click(object sender, EventArgs e)
        {

            if (lvBuy.Items != null)
            {
                backupLvBuy = new ListViewItem[lvBuy.Items.Count];
                lvBuy.Items.CopyTo(backupLvBuy, 0);
            }

            if (lvRead != null)
            {
                backupLvRead = new ListViewItem[lvRead.Items.Count];
                lvRead.Items.CopyTo(backupLvRead, 0);
            }
        }

        private void btnRestoreState_Click(object sender, EventArgs e)
        {
            lvBuy.Items.Clear();
            try { lvBuy.Items.AddRange(backupLvBuy); }
            catch { }
            

            lvRead.Items.Clear();
            try { lvRead.Items.AddRange(backupLvRead); }
            catch { }
           
        }

        private void btnSanveToFile_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(path +"\\MyBookShelf") == false)
            {
                Directory.CreateDirectory(path + "\\MyBookShelf");
            }
            
            List<String> booksToWrite = new List<string>();
            string Book = "";
            foreach (ListViewItem i in lvBuy.Items)
            {
                Book = String.Format("1$${0}$${1}$${2}$$", i.SubItems[0].Text, i.SubItems[1].Text, i.SubItems[2].Text);
                booksToWrite.Add(Book);
            }

            foreach (ListViewItem i in lvRead.Items)
            {
                Book = String.Format("2$${0}$$", i.SubItems[0].Text);
                booksToWrite.Add(Book);
            }
            System.IO.File.WriteAllLines($"{path}\\books.dat", booksToWrite);

        }

        //Comment For Test
        //How i can to push it on gitHub???
    }
}
