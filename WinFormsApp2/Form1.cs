using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using OpenCvSharp;

namespace WinFormsApp2
{

    public partial class Form1 : MaterialForm
    {
        [DllImport("USER32.DLL")]
        public static extern void SwitchToThisWindow(IntPtr hwnd, Boolean fAltTab);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hwnd, out int lpdwProcessId);
        
        [DllImport("USER32.DLL")]
        public static extern IntPtr GetTopWindow(IntPtr hwnd);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);


        private VideoCapture video = new VideoCapture(0);
        private string RequestPath = "";
        public Form1()
        {
            InitializeComponent();
            RequestPath= Application.StartupPath + @"告警图片\";
            materialSingleLineTextField_Request.Text = RequestPath;
            if (!Directory.Exists(RequestPath))
            {

                Directory.CreateDirectory(RequestPath);
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(StartVideo);
            thread.Start();
            
        }

        private void StartVideo() 
        {

            HOGDescriptor defaultHog = new HOGDescriptor();
            defaultHog.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
            using (Mat mat = new Mat())
            {
                while (video.Read(mat))
                {

                    if (materialCheckBox1.Checked == true)
                    {
                        Mat Gray = new Mat();
                        Cv2.CvtColor(mat, Gray, ColorConversionCodes.BGR2GRAY);
                        Rect[] rects = defaultHog.DetectMultiScale(Gray, 1, new OpenCvSharp.Size(8, 8), new OpenCvSharp.Size(0, 0), 1.03, 2);
                       
                        //画矩形
                        if (rects.Length > 0)
                        {
                            for (int i = 0; i < rects.Length; i++)
                            {
                                Rect r = rects[i];
                                Cv2.Rectangle(mat, r.TopLeft, r.BottomRight, new OpenCvSharp.Scalar(0, 0, 255), 3);
                                IntPtr mainHandle = Process.GetProcessesByName(materialSingleLineTextField_ProName.Text)[0].MainWindowHandle;//获取窗口句柄
                                SwitchToThisWindow(mainHandle, true);//激活窗口
                                var tempms = mat.ToMemoryStream();
                                Image.FromStream(tempms).Save(materialSingleLineTextField_Request.Text + "_" + DateTime.Now.ToString("yyyy年MM月dd日 HH时mm分ss秒", DateTimeFormatInfo.InvariantInfo) + ".jpg", ImageFormat.Jpeg);
                                tempms.Dispose();

                            }
                        }
                        Gray.Dispose();
                        rects = null;
                        var ms = mat.ToMemoryStream();
                        pictureBox1.Image = (Bitmap)Image.FromStream(ms);
                        ms.Dispose();
                        Cv2.WaitKey();
                        GC.Collect();
                    }
                    else
                    {
                        var ms = mat.ToMemoryStream();
                        pictureBox1.Image = (Bitmap)Image.FromStream(ms);
                        ms.Dispose();
                        Cv2.WaitKey(30);
                        GC.Collect();
                    }
                   
                    
                    

                   
                }
            }

        }

        /// <summary>
        /// 通过进程名检索进程句柄
        /// </summary>
        private int SelectName2Pid(string ProcessName) {
            Process[] processes = System.Diagnostics.Process.GetProcesses();
            Process process;
            int ret = -1;
            for (int i = 0; i < processes.Length - 1; i++)
            {
                process = processes[i];
                if (process.ProcessName == ProcessName)
                {
                    Debug.WriteLine(process.ProcessName);
                    ret= process.Id;
                    break;
                }

            }

            return ret;
        }

        /// <summary>
        /// 通过进程句柄检索窗口名
        /// </summary>
        /// <param name="Pid"></param>
        /// <returns></returns>
        private IntPtr SelectPid2Window(int Pid) {
            IntPtr Depsk = GetTopWindow(IntPtr.Zero);
            while (Depsk!=IntPtr.Zero)
            {
                int tempID = 0;
                IntPtr wid = GetWindowThreadProcessId(Depsk, out tempID);
                if(wid!=IntPtr.Zero)
                {
                    if (tempID == Pid)
                    {
                        Debug.WriteLine(Depsk);
                        //SwitchToThisWindow(Depsk, false);
                        return Depsk;
                    }

                }
                

                Depsk = GetWindow(Depsk, (uint)2);
            }

            return IntPtr.Zero;
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            video.Release();
            video.Dispose();
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
