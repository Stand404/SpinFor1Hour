using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Spin_for_1_hour.Properties;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;
using System.Diagnostics;

namespace Spin_for_1_hour
{
    public partial class Form1 : Form
    {
        private bool isDragging = false; // 是否正在拖动
        private Point clickLocation; // 鼠标按下时的位置

        private TimeSpan remainingTime; // 倒计时
        private Timer timer1;

        private string mp3FilePath;
        private string currentName = "汉堡";

        public Form1()
        {
            InitializeComponent();
            // 设置窗体为透明
            BackColor = Color.White; // 设置背景颜色为品红色
            TransparencyKey = Color.White; // 设置透明色
            FormBorderStyle = FormBorderStyle.None; // 去掉边框

            pictureBox1.MouseDown += Panel_MouseDown;
            pictureBox1.MouseUp += Panel_MouseUp;
            pictureBox1.MouseMove += Panel_MouseMove;
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items) item.Click += MenuItem_Click;

            // 多开但是不锁音频
            string processName = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length == 1) LoadAudio();

            // 初始化剩余时间为 1 小时
            remainingTime = new TimeSpan(1, 0, 0);
            // 设置标签显示初始时间
            time_label.Text = remainingTime.ToString("hh\\:mm\\:ss");
            // 启动计时器
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void LoadAudio()
        {
            // 生成一个临时文件路径
            string tempFilePath = Path.Combine(Path.GetTempPath(), "Spin_for_1_hour.mp3");

            using (Stream stream = new MemoryStream(Resources.Funkytown))
            {
                if (stream != null)
                {
                    // 将流保存到新的文件路径
                    using (FileStream fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fs);
                    }

                    // 使用 Windows Media Player 播放临时文件
                    MciPlayer.mciPlay(mp3FilePath);
                }
            }

            // 检查文件是否存在
            if (File.Exists(tempFilePath)) MciPlayer.mciPlay(tempFilePath);
            else
            {
                Console.WriteLine("文件不存在，从流中创建文件。");
                // 获取音频流
                using (Stream stream = new MemoryStream(Resources.Funkytown)) // 替换为你的音频流获取逻辑
                {
                    if (stream != null)
                    {
                        // 将流保存到新的文件路径
                        using (FileStream fs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                        {
                            stream.CopyTo(fs);
                        }

                        // 使用 Windows Media Player 播放临时文件
                        MciPlayer.mciPlay(tempFilePath);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 每次计时器触发时，减少 1 秒
            remainingTime = remainingTime.Subtract(new TimeSpan(0, 0, 1));

            // 更新标签显示
            time_label.Text = remainingTime.ToString("hh\\:mm\\:ss");

            // 检查时间是否为 00:00:00
            if (remainingTime.TotalSeconds <= 0)
            {
                // 停止计时器
                timer1.Stop();

                // 退出程序
                Application.Exit();
            }
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true; // 开始拖动
            clickLocation = e.Location; // 记录鼠标按下时的位置
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // 停止拖动
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // 计算窗体的新位置
                Point newLocation = new Point(
                    this.Location.X + (e.X - clickLocation.X),
                    this.Location.Y + (e.Y - clickLocation.Y)
                );
                this.Location = newLocation; // 更新窗体位置
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            // 获取触发事件的菜单项
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            // 从 Tag 属性中获取额外的字符串参数
            string parameter = clickedItem.Tag.ToString();

            ChangeItem(parameter);
        }

        private void ChangeItem(string name)
        {
            if (currentName.Equals(name)) return; 
            currentName = name;
            switch (name)
            {
                case "三明治":
                    pictureBox1.Image = Resources.三明治gif;
                    Text = "三明治旋转1小时";
                    Icon = Resources.三明治;
                    break;
                case "薯条2":
                    pictureBox1.Image = Resources.薯条2gif;
                    Text = "薯条旋转1小时";
                    Icon = Resources.薯条2;
                    break;
                case "汉堡":
                    pictureBox1.Image = Resources.汉堡gif;
                    Text = "汉堡旋转1小时";
                    Icon = Resources.汉堡;
                    break;
                case "鸡块":
                    pictureBox1.Image = Resources.鸡块gif;
                    Text = "鸡块旋转1小时";
                    Icon = Resources.鸡块;
                    break;
                case "南瓜派":
                    pictureBox1.Image = Resources.南瓜派gif;
                    Text = "南瓜派旋转1小时";
                    Icon = Resources.南瓜派;
                    break;
                case "热狗":
                    pictureBox1.Image = Resources.热狗gif;
                    Text = "热狗旋转1小时";
                    Icon = Resources.热狗;
                    break;
                case "薯条1":
                    pictureBox1.Image = Resources.薯条1gif;
                    Text = "薯条旋转1小时";
                    Icon = Resources.薯条1;
                    break;
                case "薯片":
                    pictureBox1.Image = Resources.薯片gif;
                    Text = "薯片旋转1小时";
                    Icon = Resources.薯片;
                    break;
                case "猪扒包":
                    pictureBox1.Image = Resources.猪扒包gif;
                    Text = "猪扒包旋转1小时";
                    Icon = Resources.猪扒包;
                    break;
                case "别转了":
                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}
