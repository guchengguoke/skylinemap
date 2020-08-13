using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TerraExplorerX;

namespace SkylineMap.TerrainControls
{
    public partial class UcTerrainWindowEx : UserControl
    {
        SGWorld70 globe = null;
        public SGWorld70 Globe
        {
            get
            {
                return globe;
            }
        }
        SGWorld70 pSgWorld = null;
        public UcTerrainWindowEx()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init(SGWorld70 SgWorld = null)
        {
            if (pSgWorld != null) return;
            if (SgWorld != null)
                pSgWorld = SgWorld;
            else
                pSgWorld = new SGWorld70Class();
            //Control.CheckForIllegalCrossThreadCalls = false;
            globe = (SGWorld70)axTE3DWindowEx1.CreateInstance("TerraExplorerX.SGWorld70");
            globe.OnLoadFinished += Globe_OnLoadFinished;
            globe.OnFrame += Globe_OnFrame;
            globe.OnFileClosed += Globe_OnFileClosed;
        }
        private void Globe_OnFileClosed()
        {
            ToolStripMenuItem_StartLink.Enabled = false;
            ToolStripMenuItem_EndLink.Enabled = false;
            ToolStripMenuItem_Close.Enabled = false;
        }

        private void Globe_OnFrame()
        {

        }
        private void Globe_OnLoadFinished(bool bSuccess)
        {
            ToolStripMenuItem_StartLink.Enabled = true;
            ToolStripMenuItem_EndLink.Enabled = true;
            ToolStripMenuItem_Close.Enabled = true;

        }

        private void ToolStripMenuItem_Open_Click(object sender, EventArgs e)
        {
            if (pSgWorld == null)
                Init();
            globe.Command.Execute(1001, "");
        }
        public void OpenUrl(string url)
        {
            if (pSgWorld == null)
                Init();
            globe.Open(url);
        }
        public void OpenDefaultProject()
        {
            globe.Project.Open(Application.StartupPath + @"\Default2D.fly", true);
        }
        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            if (pSgWorld == null)
                Init();
            globe.Project.Close();
        }
        public void SetMenuUnVisable()
        {
            contextMenuStrip1.Visible = false;
            button_Menu.Visible = false;
        }
        private void ToolStripMenuItem_StartLink_Click(object sender, EventArgs e)
        {
            StartLink();
        }
        public void StartLink()
        {
            try
            {
                if (pSgWorld == null)
                    Init();
                pSgWorld.Application.Multiple3DWindows.SetAsLeader();
                globe.Application.Multiple3DWindows.LinkPosition(pSgWorld);
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex);
            }
        }

        private void ToolStripMenuItem_EndLink_Click(object sender, EventArgs e)
        {
            EndLink();
        }
        public void EndLink()
        {
            try
            {
                globe.Application.Multiple3DWindows.UnlinkPosition();
            }
            catch
            {

            }
        }
        private void button_Menu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Control.MousePosition);
        }
        private void UcTerrainWindowEx_SizeChanged(object sender, EventArgs e)
        {
            button_Menu.Location = new Point(this.Width - button_Menu.Width, 0);
        }

        private void UcTerrainWindowEx_Load(object sender, EventArgs e)
        {

        }
    }
}
