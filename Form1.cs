using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace finalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstInterface();
            pictureBox6.Hide();
        }
        void firstInterface()//一開始介面
        {
            button1.Show();//map btn
            button2.Show();//list btn
            label1.Show();//mode label
            label3.Show();//標題
            button7.Show();//心理測驗btn
            button3.Hide();//back
            panel2.Hide();//map
            panel3.Hide();//list
            label2.Text = "嗨嗨~今天要用甚麼模式來探索呢?"; 
        }
        void mapInterface()//點入地圖後的介面
        {
            panel3.Hide();//list
            panel2.Show();//map
            button1.Hide();
            button2.Hide();
            label1.Hide();
            label3.Hide();
            button7.Hide();
            button3.Show();
            label2.Text ="選一個地區吧~";
        }
        void listInterface()//點入列表後的介面
        {
            panel3.Show();//list
            panel2.Hide();//map
            button1.Hide();
            button2.Hide();
            label1.Hide();
            label3.Hide();
            button7.Hide();
            button3.Show();
            label2.Text = "今天要喝什麼樣的珍奶呢?";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //map
            mapInterface();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //list
            listInterface();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstInterface();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedItem.ToString() == "東區")
            {
                
                StreamReader sr = new StreamReader("東區飲料店(無排列).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
                
            }

            else if (comboBox1.SelectedItem.ToString() == "中西區")
            {
                StreamReader sr = new StreamReader("中西區飲料店(無排列).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            else if (comboBox1.SelectedItem.ToString() == "永康區")
            {
                StreamReader sr = new StreamReader("永康區飲料店(無排列).txt", System.Text.Encoding.UTF8);//UTF8是記事本的編碼方法不能亂改歐，不然會變亂碼QQ
                while (sr.Peek() > -1)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            
            Debug.Print(listBox1.Items.Count.ToString());
        }

        //這個是當滑鼠在panel4上
        private void panel4_MouseHover(object sender, EventArgs e)
        {
            Debug.Print("4");
            pictureBox6.Show();
        }
        //這個是當滑鼠離開panel4
        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Hide();
        }

        //心理測驗的btn
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "不知道要喝甚麼的話就按這個按鈕吧!!";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label2.Text = "今天要喝什麼樣的珍奶呢?";
        }
    }
}
