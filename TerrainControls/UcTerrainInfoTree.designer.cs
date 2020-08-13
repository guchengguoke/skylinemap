namespace SkylineMap.TerrainControls
{
    partial class UcTerrainInfoTree
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTerrainInfoTree));
            this.axTEInformationWindow1 = new AxTerraExplorerX.AxTEInformationWindow();
            ((System.ComponentModel.ISupportInitialize)(this.axTEInformationWindow1)).BeginInit();
            this.SuspendLayout();
            // 
            // axTEInformationWindow1
            // 
            this.axTEInformationWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTEInformationWindow1.Enabled = true;
            this.axTEInformationWindow1.Location = new System.Drawing.Point(0, 0);
            this.axTEInformationWindow1.Name = "axTEInformationWindow1";
            this.axTEInformationWindow1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTEInformationWindow1.OcxState")));
            this.axTEInformationWindow1.Size = new System.Drawing.Size(303, 649);
            this.axTEInformationWindow1.TabIndex = 0;
            // 
            // UcTerrainInfoTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axTEInformationWindow1);
            this.Name = "UcTerrainInfoTree";
            this.Size = new System.Drawing.Size(303, 649);
            this.Load += new System.EventHandler(this.UcTerrainInfoTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axTEInformationWindow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxTerraExplorerX.AxTEInformationWindow axTEInformationWindow1;
    }
}
