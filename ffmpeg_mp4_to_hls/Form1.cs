using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffmpeg_mp4_to_hls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //static string FFmpegPath = "C:\\Users\\nick\\Desktop\\Ffmpeg_To_Hls\\Ffmpeg_To_Hls\\bin\\Debug\\ffmpeg\\bin\\x86\\ffmpeg.exe";
        static string FFmpegPath = ".\\ffmpeg\\bin\\x86\\ffmpeg.exe";
        private void Form1_Load(object sender, EventArgs e)
        {
            return;
        }
        static void RunMyProcess(string Parameters)
        {
            var p = new Process();
            p.StartInfo.FileName = FFmpegPath;
            p.StartInfo.Arguments = Parameters;
            //是否使用操作系统shell启动
            p.StartInfo.UseShellExecute = false;
            //不显示程序窗口
            //p.StartInfo.CreateNoWindow = true;
            p.Start();
            Console.WriteLine("編碼開始");
            p.WaitForExit();
            p.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        static void CheckOrCreateDir(string target_dir)
        {
            if (!Directory.Exists(target_dir))
                Directory.CreateDirectory(target_dir);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(Path.GetDirectoryName(@"C:\hello\my\dear\world.hm"));
            string mp4_resource = textBox1.Text;
            string target_dir = textBox2.Text;

            if (mp4_resource == "")
            {
                MessageBox.Show("錯誤 ： " + label1.Text + " ？ ");
                return;
            }
            else if (target_dir == "")
            {
                MessageBox.Show("錯誤 ： " + label2.Text + " ？ ");
                return;
            }
            string pixel_path = "";
            string pixel_str = "";
            string output = "";

            string para = " -re -i " + mp4_resource + " -y  ";
            if (checkBox200p.Checked)
            {
                pixel_str = "200p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s cga  -f hls -hls_list_size 0 " + output;
            }
            if (checkBox360p.Checked)
            {
                pixel_str = "360p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s nhd  -f hls -hls_list_size 0 " + output;
            }
            if (checkBox480p.Checked)
            {
                pixel_str = "480p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s hd480 -f hls -hls_list_size 0 " + output;
            }
            if (checkBox720p.Checked)
            {
                pixel_str = "720p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s hd720 -f hls -hls_list_size 0 " + output;
            }
            if (checkBox1080p.Checked)
            {
                pixel_str = "1080p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s hd1080 -f hls -hls_list_size 0 " + output;
            }
            if (checkBox1440p.Checked)
            {
                pixel_str = "1440p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s 2560x1440 -f hls -hls_list_size 0 " + output;
            }
            if (checkBox2160p.Checked)
            {
                pixel_str = "2160p";
                pixel_path = target_dir + pixel_str;
                CheckOrCreateDir(pixel_path);
                output = target_dir + pixel_str + "/" + pixel_str + ".m3u8 ";
                para += " -c:a aac -c:v libx264 -s uhd2160 -f hls -hls_list_size 0 " + output;
            }
            RunMyProcess(para);
            Console.WriteLine("完成！");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
