using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GASS.CUDA;

namespace LibRawTest
{
    public partial class FormGpuList : Form
    {
        CUDA mCuda;
        int mSelectedGpuIndex = 0;

        public FormGpuList()
        {
            InitializeComponent();

            mCuda = new CUDA(true);
            for (int i = 0; i < mCuda.Devices.Length; i++)
            {
                lbGpuNames.Items.Add(mCuda.Devices[i].Name);
            }
            lbGpuNames.SelectedIndex = 0;
        }

        public int SelectedGpuIndex
        {
            get { return mSelectedGpuIndex; }
        }

        private void lbGpuNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mSelectedGpuIndex = this.lbGpuNames.SelectedIndex;
            this.pbGpuPropertiesDetail.SelectedObject = mCuda.Devices[this.lbGpuNames.SelectedIndex].Properties;
            this.pbGpuPropertiesGeneral.SelectedObject = mCuda.Devices[this.lbGpuNames.SelectedIndex];
        }
    }
}