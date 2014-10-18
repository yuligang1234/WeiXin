namespace WindowsFormsApplication1
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.axChinaExcel1 = new AxChinaExcelLib.AxChinaExcel();
            ((System.ComponentModel.ISupportInitialize)(this.axChinaExcel1)).BeginInit();
            this.SuspendLayout();
            // 
            // axChinaExcel1
            // 
            this.axChinaExcel1.Enabled = true;
            this.axChinaExcel1.Location = new System.Drawing.Point(12, 12);
            this.axChinaExcel1.Name = "axChinaExcel1";
            this.axChinaExcel1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axChinaExcel1.OcxState")));
            this.axChinaExcel1.Size = new System.Drawing.Size(1234, 483);
            this.axChinaExcel1.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 693);
            this.Controls.Add(this.axChinaExcel1);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.axChinaExcel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxChinaExcelLib.AxChinaExcel axChinaExcel1;
    }
}