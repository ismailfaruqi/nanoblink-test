namespace LibRawTest
{
    partial class LibRawTestGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demosaicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noInterpolationHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCDCPUSingleFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCDCPUSingleFrameBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCDGPUSingleFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCDGPUMultiFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeofLibRawimgparamsimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.halfSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.grayscaleGPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.paramsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1075, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.demosaicToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // demosaicToolStripMenuItem
            // 
            this.demosaicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.grayscaleGPUToolStripMenuItem,
            this.noInterpolationToolStripMenuItem,
            this.noInterpolationHToolStripMenuItem,
            this.vCDCPUSingleFrameToolStripMenuItem,
            this.vCDCPUSingleFrameBackgroundToolStripMenuItem,
            this.vCDGPUSingleFrameToolStripMenuItem,
            this.vCDGPUMultiFrameToolStripMenuItem});
            this.demosaicToolStripMenuItem.Name = "demosaicToolStripMenuItem";
            this.demosaicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.demosaicToolStripMenuItem.Text = "&Demosaic";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.grayscaleToolStripMenuItem.Text = "&Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // noInterpolationToolStripMenuItem
            // 
            this.noInterpolationToolStripMenuItem.Name = "noInterpolationToolStripMenuItem";
            this.noInterpolationToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.noInterpolationToolStripMenuItem.Text = "No &Interpolation";
            this.noInterpolationToolStripMenuItem.Click += new System.EventHandler(this.noInterpolationToolStripMenuItem_Click);
            // 
            // noInterpolationHToolStripMenuItem
            // 
            this.noInterpolationHToolStripMenuItem.Name = "noInterpolationHToolStripMenuItem";
            this.noInterpolationHToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.noInterpolationHToolStripMenuItem.Text = "No Interpolation (Half Size)";
            this.noInterpolationHToolStripMenuItem.Click += new System.EventHandler(this.noInterpolationHToolStripMenuItem_Click);
            // 
            // vCDCPUSingleFrameToolStripMenuItem
            // 
            this.vCDCPUSingleFrameToolStripMenuItem.Name = "vCDCPUSingleFrameToolStripMenuItem";
            this.vCDCPUSingleFrameToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.vCDCPUSingleFrameToolStripMenuItem.Text = "VCD &CPU Single Frame";
            this.vCDCPUSingleFrameToolStripMenuItem.Click += new System.EventHandler(this.vCDCPUSingleFrameToolStripMenuItem_Click);
            // 
            // vCDCPUSingleFrameBackgroundToolStripMenuItem
            // 
            this.vCDCPUSingleFrameBackgroundToolStripMenuItem.Name = "vCDCPUSingleFrameBackgroundToolStripMenuItem";
            this.vCDCPUSingleFrameBackgroundToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.vCDCPUSingleFrameBackgroundToolStripMenuItem.Text = "VCD CPU Single Frame (Background)";
            this.vCDCPUSingleFrameBackgroundToolStripMenuItem.Click += new System.EventHandler(this.vCDCPUSingleFrameBackgroundToolStripMenuItem_Click);
            // 
            // vCDGPUSingleFrameToolStripMenuItem
            // 
            this.vCDGPUSingleFrameToolStripMenuItem.Name = "vCDGPUSingleFrameToolStripMenuItem";
            this.vCDGPUSingleFrameToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.vCDGPUSingleFrameToolStripMenuItem.Text = "VCD &GPU Single Frame One Pass";
            this.vCDGPUSingleFrameToolStripMenuItem.Click += new System.EventHandler(this.vCDGPUSingleFrameToolStripMenuItem_Click);
            // 
            // vCDGPUMultiFrameToolStripMenuItem
            // 
            this.vCDGPUMultiFrameToolStripMenuItem.Name = "vCDGPUMultiFrameToolStripMenuItem";
            this.vCDGPUMultiFrameToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.vCDGPUMultiFrameToolStripMenuItem.Text = "VCD GPU &Single Frame Multi Pass";
            this.vCDGPUMultiFrameToolStripMenuItem.Click += new System.EventHandler(this.vCDGPUMultiFrameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeofLibRawimgparamsimageToolStripMenuItem,
            this.gPUsToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "&Test";
            // 
            // sizeofLibRawimgparamsimageToolStripMenuItem
            // 
            this.sizeofLibRawimgparamsimageToolStripMenuItem.Name = "sizeofLibRawimgparamsimageToolStripMenuItem";
            this.sizeofLibRawimgparamsimageToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.sizeofLibRawimgparamsimageToolStripMenuItem.Text = "sizeof(LibRaw::img_params::image)";
            this.sizeofLibRawimgparamsimageToolStripMenuItem.Click += new System.EventHandler(this.sizeofLibRawimgparamsimageToolStripMenuItem_Click);
            // 
            // gPUsToolStripMenuItem
            // 
            this.gPUsToolStripMenuItem.Name = "gPUsToolStripMenuItem";
            this.gPUsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.gPUsToolStripMenuItem.Text = "GPUs";
            this.gPUsToolStripMenuItem.Click += new System.EventHandler(this.gPUsToolStripMenuItem_Click);
            // 
            // paramsToolStripMenuItem
            // 
            this.paramsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.halfSizeToolStripMenuItem});
            this.paramsToolStripMenuItem.Name = "paramsToolStripMenuItem";
            this.paramsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.paramsToolStripMenuItem.Text = "Params";
            // 
            // halfSizeToolStripMenuItem
            // 
            this.halfSizeToolStripMenuItem.CheckOnClick = true;
            this.halfSizeToolStripMenuItem.Name = "halfSizeToolStripMenuItem";
            this.halfSizeToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.halfSizeToolStripMenuItem.Text = "Half Size";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 513);
            this.splitContainer1.SplitterDistance = 840;
            this.splitContainer1.TabIndex = 2;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(16, 14);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(201, 196);
            this.propertyGrid1.TabIndex = 0;
            // 
            // grayscaleGPUToolStripMenuItem
            // 
            this.grayscaleGPUToolStripMenuItem.Name = "grayscaleGPUToolStripMenuItem";
            this.grayscaleGPUToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.grayscaleGPUToolStripMenuItem.Text = "Grayscale GPU";
            this.grayscaleGPUToolStripMenuItem.Click += new System.EventHandler(this.grayscaleGPUToolStripMenuItem_Click);
            // 
            // LibRawTestGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 537);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibRawTestGui";
            this.Text = "LibRaw Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeofLibRawimgparamsimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demosaicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCDCPUSingleFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCDGPUSingleFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCDGPUMultiFrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noInterpolationHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem halfSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCDCPUSingleFrameBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleGPUToolStripMenuItem;
    }
}

