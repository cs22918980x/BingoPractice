using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();  //產生25個不重複亂數
            int[] number = new int[25];
            for (int a = 0; a < 25; a++)
            {
                number[a] = a +1;
            }
            int temp;             //要暫存地址       現在number[0~25]=0~25
            for (int a = 0; a < 25; a++) 
            {
                int i = r.Next(25);        //先一個亂數 ex:5
                temp = number[a];          //把1暫存到temp
                number[a] = number[i];     //讓5 存入 [0] 
                number[i] = temp;          //把1的位置存入
            }

            Button[] btns = new Button[25]; // 產生 25 個 Button Reference，並初始化為 null
            for (int y = 0; y < 5; ++y)
            {
                for (int x = 0; x < 5; ++x)
                {
                    int ixy = x + y * 5;
                    btns[ixy] = new Button();
                    btns[ixy].Left = 2* x * btns[0].Width;
                    btns[ixy].Top = 2* y * btns[0].Height;

                }
            }
            for (int i=0; i<25; i++)
            {
                btns[i].Text = "" + number[i];
            }
            this.Controls.AddRange(btns);
        }
    }
}
