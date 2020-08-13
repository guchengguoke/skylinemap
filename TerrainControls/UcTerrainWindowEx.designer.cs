namespace SkylineMap.TerrainControls
{
    partial class UcTerrainWindowEx
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
            this.components = new System.ComponentModel.Container();
            this.axTE3DWindowEx1 = new AxTerraExplorerX.AxTE3DWindowEx();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_StartLink = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_EndLink = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axTE3DWindowEx1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axTE3DWindowEx1
            // 
            this.axTE3DWindowEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTE3DWindowEx1.Enabled = true;
            this.axTE3DWindowEx1.Location = new System.Drawing.Point(0, 0);
            this.axTE3DWindowEx1.Name = "axTE3DWindowEx1";
            this.axTE3DWindowEx1.Size = new System.Drawing.Size(327, 298);
            this.axTE3DWindowEx1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_StartLink,
            this.ToolStripMenuItem_EndLink,
            this.ToolStripMenuItem_Close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 100);
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(138, 24);
            this.ToolStripMenuItem_Open.Text = "打开";
            this.ToolStripMenuItem_Open.Click += new System.EventHandler(this.ToolStripMenuItem_Open_Click);
            // 
            // ToolStripMenuItem_StartLink
            // 
            this.ToolStripMenuItem_StartLink.Enabled = false;
            this.ToolStripMenuItem_StartLink.Name = "ToolStripMenuItem_StartLink";
            this.ToolStripMenuItem_StartLink.Size = new System.Drawing.Size(138, 24);
            this.ToolStripMenuItem_StartLink.Text = "开启联动";
            this.ToolStripMenuItem_StartLink.Click += new System.EventHandler(this.ToolStripMenuItem_StartLink_Click);
            // 
            // ToolStripMenuItem_EndLink
            // 
            this.ToolStripMenuItem_EndLink.Enabled = false;
            this.ToolStripMenuItem_EndLink.Name = "ToolStripMenuItem_EndLink";
            this.ToolStripMenuItem_EndLink.Size = new System.Drawing.Size(138, 24);
            this.ToolStripMenuItem_EndLink.Text = "取消联动";
            this.ToolStripMenuItem_EndLink.Click += new System.EventHandler(this.ToolStripMenuItem_EndLink_Click);
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Enabled = false;
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            this.ToolStripMenuItem_Close.Size = new System.Drawing.Size(138, 24);
            this.ToolStripMenuItem_Close.Text = "关闭";
            this.ToolStripMenuItem_Close.Click += new System.EventHandler(this.ToolStripMenuItem_Close_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Menu.Location = new System.Drawing.Point(306, 0);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(21, 23);
            this.button_Menu.TabIndex = 1;
            this.button_Menu.Text = "↓";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // UcTerrainWindowEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Menu);
            this.Controls.Add(this.axTE3DWindowEx1);
            this.Name = "UcTerrainWindowEx";
            this.Size = new System.Drawing.Size(327, 298);
            this.Load += new System.EventHandler(this.UcTerrainWindowEx_Load);
            this.SizeChanged += new System.EventHandler(this.UcTerrainWindowEx_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axTE3DWindowEx1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public AxTerraExplorerX.AxTE3DWindowEx axTE3DWindowEx1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_StartLink;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EndLink;
        private System.Windows.Forms.Button button_Menu;
    }
}
