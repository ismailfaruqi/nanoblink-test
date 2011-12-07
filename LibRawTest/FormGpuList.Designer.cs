namespace LibRawTest
{
    partial class FormGpuList
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
            this.lbGpuNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGpuPropertiesDetail = new System.Windows.Forms.PropertyGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbGpuPropertiesGeneral = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // lbGpuNames
            // 
            this.lbGpuNames.FormattingEnabled = true;
            this.lbGpuNames.Location = new System.Drawing.Point(12, 38);
            this.lbGpuNames.Name = "lbGpuNames";
            this.lbGpuNames.Size = new System.Drawing.Size(120, 95);
            this.lbGpuNames.TabIndex = 0;
            this.lbGpuNames.SelectedIndexChanged += new System.EventHandler(this.lbGpuNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPU List:";
            // 
            // pbGpuPropertiesDetail
            // 
            this.pbGpuPropertiesDetail.Location = new System.Drawing.Point(138, 229);
            this.pbGpuPropertiesDetail.Name = "pbGpuPropertiesDetail";
            this.pbGpuPropertiesDetail.Size = new System.Drawing.Size(230, 273);
            this.pbGpuPropertiesDetail.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(293, 508);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pbGpuPropertiesGeneral
            // 
            this.pbGpuPropertiesGeneral.Location = new System.Drawing.Point(138, 12);
            this.pbGpuPropertiesGeneral.Name = "pbGpuPropertiesGeneral";
            this.pbGpuPropertiesGeneral.Size = new System.Drawing.Size(230, 211);
            this.pbGpuPropertiesGeneral.TabIndex = 4;
            // 
            // FormGpuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(380, 543);
            this.Controls.Add(this.pbGpuPropertiesGeneral);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbGpuPropertiesDetail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGpuNames);
            this.Name = "FormGpuList";
            this.Text = "GPU List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGpuNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PropertyGrid pbGpuPropertiesDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PropertyGrid pbGpuPropertiesGeneral;
    }
}