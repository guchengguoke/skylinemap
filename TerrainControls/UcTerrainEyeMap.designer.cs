namespace SkylineMap.TerrainControls
{
    partial class UcTerrainEyeMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTerrainEyeMap));
            this.axTENavigationMap1 = new AxTerraExplorerX.AxTENavigationMap();
            ((System.ComponentModel.ISupportInitialize)(this.axTENavigationMap1)).BeginInit();
            this.SuspendLayout();
            // 
            // axTENavigationMap1
            // 
            this.axTENavigationMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTENavigationMap1.Enabled = true;
            this.axTENavigationMap1.Location = new System.Drawing.Point(0, 0);
            this.axTENavigationMap1.Name = "axTENavigationMap1";
            this.axTENavigationMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTENavigationMap1.OcxState")));
            this.axTENavigationMap1.Size = new System.Drawing.Size(542, 484);
            this.axTENavigationMap1.TabIndex = 0;
            // 
            // UcTerrainEyeMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axTENavigationMap1);
            this.Name = "UcTerrainEyeMap";
            this.Size = new System.Drawing.Size(542, 484);
            ((System.ComponentModel.ISupportInitialize)(this.axTENavigationMap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxTerraExplorerX.AxTENavigationMap axTENavigationMap1;
    }
}
