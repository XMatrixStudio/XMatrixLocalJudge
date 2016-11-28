using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMatrix_Local_Judge
{
    public delegate void DelReadStdOutput(string result);
    public delegate void DelReadErrOutput(string result);
    public partial class Form1 : Form
    {
        public event DelReadStdOutput ReadStdOutput;
        public event DelReadErrOutput ReadErrOutput;
        String problemInfo; //储存IP

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //3.将相应函数注册到委托事件中  
            ReadStdOutput += new DelReadStdOutput(ReadStdOutputAction);
            ReadErrOutput += new DelReadErrOutput(ReadErrOutputAction);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webProgram.Navigate(System.AppDomain.CurrentDomain.BaseDirectory + "welcome.html");//加载网页
            buttonUpdate_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter("a.c");
            sw.Write(textInput.Text);
            sw.Close();
            RealAction("C:\\Program Files (x86)\\Dev-Cpp\\MinGW64\\bin\\gcc.exe", "a.c -std=c99");
           // RealAction("ping.exe", "192.168.123.1");
            //调用进程
            
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine("a.exe > out.txt < in.txt");//输入命令
            process.StandardInput.WriteLine("exit");
            string sh = process.StandardOutput.ReadToEnd();
            process.Close();
            textOutput.AppendText(sh);// 追加文本，并且使得光标定位到插入地方。
            textOutput.ScrollToCaret();
            this.textOutput.Focus();//获取焦点
            this.textOutput.Select(this.textOutput.TextLength, 0);//光标定位到文本最后
            this.textOutput.ScrollToCaret();//滚动到光标处
            
        }

        private void RealAction(string StartFileName, string StartFileArg)
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = StartFileName;      // 命令  
            CmdProcess.StartInfo.Arguments = StartFileArg;      // 参数  
            CmdProcess.StartInfo.CreateNoWindow = true;         // 不创建新窗口  
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;  // 重定向输入  
            CmdProcess.StartInfo.RedirectStandardOutput = true; // 重定向标准输出  
            CmdProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                                                                //CmdProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  

            CmdProcess.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            CmdProcess.ErrorDataReceived += new DataReceivedEventHandler(p_ErrorDataReceived);

            CmdProcess.EnableRaisingEvents = true;                      // 启用Exited事件  
            CmdProcess.Exited += new EventHandler(CmdProcess_Exited);   // 注册进程结束事件  

            CmdProcess.Start();
            CmdProcess.BeginOutputReadLine();
            CmdProcess.BeginErrorReadLine();

            // 如果打开注释，则以同步方式执行命令，此例子中用Exited事件异步执行。  
             CmdProcess.WaitForExit();       
        }
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // 4. 异步调用，需要invoke  
                this.Invoke(ReadStdOutput, new object[] { e.Data });
            }
        }

        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                this.Invoke(ReadErrOutput, new object[] { e.Data });
            }
        }

        private void ReadStdOutputAction(string result)
        {
            this.textOutput.AppendText(result + "\r\n");
        }

        private void ReadErrOutputAction(string result)
        {
            this.textOutput.AppendText(result + "\r\n");
        }

        private void CmdProcess_Exited(object sender, EventArgs e)
        {
            // 执行结束后触发  
            //textOutput.ScrollToCaret();
            //this.textOutput.Focus();//获取焦点
            //this.textOutput.Select(this.textOutput.TextLength, 0);//光标定位到文本最后
            //this.textOutput.ScrollToCaret();//滚动到光标处
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
