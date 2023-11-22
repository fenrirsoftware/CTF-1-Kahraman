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
using static System.Net.Mime.MediaTypeNames;

namespace Kahraman

{ //hint 
    //maps kullan


   
    public partial class 窗体 : Form
    {

        private int 生成的密码;
        string 分机 = "cat";


        public 窗体()
        {
            InitializeComponent();
            生成的密码 = 生成密码();
          
            
            

        }



        private void 按钮检查密码_Click(object sender, EventArgs e)
        {
            string 输入的密码 = 文本框密码.Text;

            int 输入的密码整数;
            if (int.TryParse(输入的密码, out 输入的密码整数))
            {
                // 如果输入的值可以转换为整数，则进行比较
                if (输入的密码整数 == 生成的密码)
                {   
                    MessageBox.Show("Şifre doğru!");


                    string 文件路径 = "dosya.coderx37";
                    string 新文件名 = Path.ChangeExtension(文件路径,"."+ 应用(分机));


                    try
                    {
                        File.Move(文件路径, 新文件名);
                        MessageBox.Show("Dosya uzantısı değiştirildi!");    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya uzantısı değiştirilemedi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Şifre yanlış!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen sadece sayılardan oluşan bir şifre girin!");
            }
        }

        private int 生成密码()
        {
            // 生成包含 5 位随机数字的密码
            Random 随机数生成器 = new Random();
            int 密码长度 = 5;
            int 密码 = 0;

            for (int i = 0; i < 密码长度; i++)
            {
                // 添加一个在 0 到 9 之间的随机数字
                密码 = 密码 * 10 + 随机数生成器.Next(10);
            }

            return 密码;
        }


        static string 应用(string 输入)
        {
            char[] 字符数组 = 输入.ToCharArray();

            for (int i = 0; i < 字符数组.Length; i++)
            {
                char 字符 = 字符数组[i];

                if (字符 >= 'a' && 字符 <= 'z')
                {
                    字符数组[i] = (char)(((字符 - 'a' + 13) % 26) + 'a');
                }
                else if (字符 >= 'A' && 字符 <= 'Z')
                {
                    字符数组[i] = (char)(((字符 - 'A' + 13) % 26) + 'A');
                }
            }

            return new string(字符数组);
        }



    }
}
