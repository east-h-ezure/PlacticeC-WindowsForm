using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp
{
    public partial class Form1 : Form
    {
            private object labelMessage;
            private object textBoxName;
        public Form1()
        {
            InitializeComponent();
        }

        // 「OK」ボタンをクリックしたときの処理
        private void button1_Click(object sender, EventArgs e)
        {
            // ラベルにテキストボックスのテキストを表示
            labelMessage.Text = textBoxName.Text + "さん、こんにちは。";

        }

        // フォームロード時の処理
        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessage.Text = "";
        }
    }
}
