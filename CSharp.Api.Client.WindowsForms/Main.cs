using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using CSharp.Api.Client.Domain.Enums;
using CSharp.Api.Client.Web;
using CSharp.Api.Client.Web.FileApiServices;

namespace CSharp.Api.Client.WindowsForms
{
    public partial class Main : Form
    {
        string UpFile1;
        string UpFile2;
        string UpFile3;
        SDKTest SdkTest;

        delegate void WriteToFormCallback(string text);
        private Thread TextBoxWriteThread = null;

        public Main()
        {
            SdkTest = new SDKTest();
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UpOpenBtn1_Click(object sender, EventArgs e)
        {
            if (UpFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UpFile1 = UpFileDialog1.FileName;
                UpOpenLbl1.Text = Path.GetFileName(UpFileDialog1.FileName);
            }
        }

        private void UpOpenBtn2_Click(object sender, EventArgs e)
        {
            if (UpFileDialog2.ShowDialog() == DialogResult.OK)
            {
                UpFile2 = UpFileDialog2.FileName;
                UpOpenLbl2.Text = Path.GetFileName(UpFileDialog2.FileName);
            }
        }
        private void UpOpenBtn3_Click(object sender, EventArgs e)
        {
            if (UpFileDialog3.ShowDialog() == DialogResult.OK)
            {
                UpFile3 = UpFileDialog3.FileName;
                UpOpenLbl3.Text = Path.GetFileName(UpFileDialog3.FileName);
            }
        }

        private void UpStartBtn1_Click(object sender, EventArgs e)
        {
            var filesCount = Convert.ToInt32(textBox7.Text ?? "1");
            var threads = Convert.ToInt32(UpThreadsTB1.Text ?? "1");
            UpOutTB1.Text += SdkTest.UploadFiles(CallType.Forms, UpFile1, filesCount, threads) + "\r\n";
            //var workerThread = new Thread(WriteToForm);
            //workerThread.Start();
            this.TextBoxWriteThread = new Thread(new ThreadStart(ThreadProcSafe));

            //this.TextBoxWriteThread.Start();
        }
        private void UpStartBtn2_Click(object sender, EventArgs e)
        {
            var filesCount = Convert.ToInt32(UpCountTB2.Text ?? "1");
            var threads = Convert.ToInt32(UpThreadsTB2.Text ?? "1");
            UpOutTB2.Text += SdkTest.UploadFiles(CallType.Forms, UpFile2, filesCount, threads) + "\r\n";
            //var workerThread = new Thread(WriteToForm);
            //workerThread.Start();
            this.TextBoxWriteThread = new Thread(new ThreadStart(ThreadProcSafe));
        }

        private void UpStartBtn3_Click(object sender, EventArgs e)
        {
            var filesCount = Convert.ToInt32(UpCountTB3.Text ?? "1");
            var threads = Convert.ToInt32(UpThreadsTB3.Text ?? "1");
            UpOutTB3.Text += SdkTest.UploadFiles(CallType.Forms, UpFile3, filesCount, threads) + "\r\n";
            //var workerThread = new Thread(WriteToForm);
            //workerThread.Start();
            this.TextBoxWriteThread = new Thread(new ThreadStart(ThreadProcSafe));
        }

        private void ThreadProcSafe()
        {
            while (true)
            {
                var consoleOut = new StringWriter();
                Console.SetOut(consoleOut);
                var s = Console.ReadLine();
                WriteToForm(consoleOut.ToString());
                //WriteToForm(1);
            }

        }

        // This method demonstrates a pattern for making thread-safe
        // calls on a Windows Forms control. 
        //
        // If the calling thread is different from the thread that
        // created the TextBox control, this method creates a
        // SetTextCallback and calls itself asynchronously using the
        // Invoke method.
        //
        // If the calling thread is the same as the thread that created
        // the TextBox control, the Text property is set directly. 

        private void WriteToForm(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (UpOutTB1.InvokeRequired)
            {
                WriteToFormCallback d = new WriteToFormCallback(WriteToForm);
                Invoke(d, new object[] { text });
            }
            else
            {
                UpOutTB1.Text += text;
            }
        }

        private void WriteToForm()
        {
            while (true)
            {
                UpOutTB1.Text += Console.Read();
            }
        }

        private void WriteToForm(int a)
        {
            UpOutTB1.Text += Console.Read();
        }

        private void StartViewPdfBtn_Click(object sender, EventArgs e)
        {
            var filesCount = Convert.ToInt32(ViewPdfCountTB.Text ?? "1");
            var threads = Convert.ToInt32(ViewPdfThreadsTB.Text ?? "1");
            var parameters = new UploadParams()
            {
                Count = filesCount,
                Threads = threads,
                FileName = ViewPdfFileNameTB.Text
            };
            SdkTest.ViewPDF(CallType.Forms, parameters);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (UpFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UpFile1 = UpFileDialog1.FileName;
                label15.Text = Path.GetFileName(UpFileDialog1.FileName);
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var filesCount = Convert.ToInt32(textBox9.Text ?? "1");
            var threads = Convert.ToInt32(textBox8.Text ?? "1");
            textBox7.Text += SdkTest.UploadFiles(CallType.Forms, UpFile1, filesCount, threads) + "\r\n";
            //var workerThread = new Thread(WriteToForm);
            //workerThread.Start();
            this.TextBoxWriteThread = new Thread(new ThreadStart(ThreadProcSafe));

            //this.TextBoxWriteThread.Start();

        }

        private void ViewPdfFileNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}