using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMatrix_Local_Judge
{
    public partial class Form1 : Form
    {
        String problemInfo; //储存IP

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webProgram.Navigate(System.AppDomain.CurrentDomain.BaseDirectory + "welcome.html");//加载网页
            buttonUpdate_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //调用进程
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string str = "gcc";
            //string str = "help";
            process.StandardInput.WriteLine(str);//输入命令
            process.StandardInput.WriteLine("exit");
            string sh = process.StandardOutput.ReadToEnd();
            process.Close();
            textOutput.AppendText(sh);// 追加文本，并且使得光标定位到插入地方。
            textOutput.ScrollToCaret();
            this.textOutput.Focus();//获取焦点
            this.textOutput.Select(this.textOutput.TextLength, 0);//光标定位到文本最后
            this.textOutput.ScrollToCaret();//滚动到光标处
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.textOutput.Height = this.Height - this.textOutput.Top - 50; // 动态调整textbox2大小
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            listProgram.Items.Clear();

            XmlDocument xmlProblemList = new XmlDocument();
            xmlProblemList.Load("problem.xml");
            XmlNode website = xmlProblemList.SelectSingleNode("website");
            
            XmlElement websiteXE = (XmlElement)website;// 将节点转换为元素，便于得到节点的属性值IP
            problemInfo = websiteXE.GetAttribute("IP").ToString();//储存IP地址
            //listProgram.Items.Add(problemInfo);//测试，输出IP

            XmlNodeList problemNameList = website.ChildNodes;
            
            foreach (XmlNode xn in problemNameList)
            {
                listProgram.Items.Add(xn.InnerText);
            }
        }

        private void listProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            String web = listProgram.SelectedItem.ToString();
            webProgram.Navigate("http://" + problemInfo + "/" + web + ".html");//加载网页
        }
    }
}
