using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibRawPort;

namespace LibRawTest
{
    public partial class LibRawTestGui : Form
    {
        private LibRawNet<float> libRaw;

        public LibRawTestGui()
        {
            InitializeComponent();

            libRaw = new LibRawNet<float>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                                    
                libRaw.Recycle();
                libRaw.DocumentMode = 2;
                libRaw.OutputBps = 16;
                libRaw.UserFlip = 0;
                libRaw.NoAutoBright = 0;
                libRaw.HalfSize = halfSizeToolStripMenuItem.Checked;
                libRaw.OpenFile(ofd.FileName);
                libRaw.Unpack();
                this.propertyGrid1.SelectedObject = libRaw;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void sizeofLibRawimgparamsimageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(libRaw.ElementSize.ToString());
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = libRaw.RawGrayscale();
        }

        private void noInterpolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = libRaw.RawNoInterpolation();
        }

        private void vCDCPUSingleFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime tb; DateTime ta;
            PixelTypeCount count = new PixelTypeCount();
            tb = DateTime.Now;
            this.pictureBox1.Image = libRaw.RawVcdCpuSingleFrame(count);
            ta = DateTime.Now;
            TimeSpan delta = ta.Subtract(tb);
            MessageBox.Show("Time required: " + delta.TotalMilliseconds + " ms, non edge pixels = " + count.NonEdgeCount);
        }

        private void vCDGPUSingleFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime tb; DateTime ta;
            tb = DateTime.Now;
            this.pictureBox1.Image = libRaw.RawVcdGpuSingleFrameOnePass();
            ta = DateTime.Now;
            TimeSpan delta = ta.Subtract(tb);
            MessageBox.Show("Time required: " + delta.TotalMilliseconds + " ms.");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            this.propertyGrid1.SelectedObject = null;
            libRaw.Recycle();
        }

        private void gPUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGpuList gpus = new FormGpuList();
            gpus.ShowDialog();
        }

        private void noInterpolationHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = libRaw.RawNoInterpolationHalfSize();
        }

        private void vCDCPUSingleFrameBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(this.RawVcdCpuNoInterpolationBG);
            bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.InterpolationCompletedBG); 
            bw.RunWorkerAsync();
        }

        private void RawVcdCpuNoInterpolationBG(object sender, DoWorkEventArgs e)
        {
            DateTime tb = DateTime.Now;
            PixelTypeCount count = new PixelTypeCount();
            Image result = libRaw.RawVcdCpuSingleFrame(count);
            BackgroundWorker bw = (BackgroundWorker)sender;
            InterpolationResult ir = new InterpolationResult();
            ir.Image = result;
            ir.TimeStarted = tb;
            e.Result = ir;
        }

        private void InterpolationCompletedBG(object sender, RunWorkerCompletedEventArgs e)
        {
            DateTime ta = DateTime.Now;
            InterpolationResult r = (InterpolationResult)e.Result;
            DateTime tb = r.TimeStarted;
            TimeSpan delta = ta.Subtract(tb);
            this.pictureBox1.Image = r.Image;
            MessageBox.Show("Time required: " + delta.TotalMilliseconds + " ms.");
        }

        private void vCDGPUMultiFrameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime tb; DateTime ta;
            tb = DateTime.Now;
            this.pictureBox1.Image = libRaw.RawVcdGpuSingleFrameMultiPass();
            ta = DateTime.Now;
            TimeSpan delta = ta.Subtract(tb);
            MessageBox.Show("Time required: " + delta.TotalMilliseconds + " ms.\n" +
                "Host to Device = " + libRaw.LastVcdSfMpKernelTimes.HostToDevice + " ms.\n" + 
                "Convert Input kernel = " + libRaw.LastVcdSfMpKernelTimes.ConvertInput + " ms.\n" + 
                "Calculate Temp Green kernel = " + libRaw.LastVcdSfMpKernelTimes.CalcTempGreen + " ms.\n" +
                "Calculate E kernel = " + libRaw.LastVcdSfMpKernelTimes.CalcE + " ms.\n" +
                "Separate Input kernel = " + libRaw.LastVcdSfMpKernelTimes.SeparateInput + " ms.\n" +
                "Calculate Temp Var Pos kernel = " + libRaw.LastVcdSfMpKernelTimes.CalcTempVarPos + " ms.\n" +
                "Calculate Var Neg kernel = " + libRaw.LastVcdSfMpKernelTimes.CalcVarNeg + " ms.\n" +
                "Convert Output kernel = " + libRaw.LastVcdSfMpKernelTimes.ConvertOutput + " ms.\n" + 
                "Device To Host = " + libRaw.LastVcdSfMpKernelTimes.DeviceToHost + " ms.");
        }

        private void grayscaleGPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime tb; DateTime ta;
            tb = DateTime.Now;
            this.pictureBox1.Image = libRaw.RawGpuTest();
            ta = DateTime.Now;
            TimeSpan delta = ta.Subtract(tb);
            MessageBox.Show("Time required: " + delta.TotalMilliseconds + " ms.");
        }
    }

    public class InterpolationResult
    {
        private Image image;
        private DateTime time;

        public Image Image
        {
            get { return image; }
            set { image = value; }
        }

        public DateTime TimeStarted
        {
            get { return time; }
            set { time = value; }
        }
    }

    
}