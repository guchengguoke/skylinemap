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
    public partial class UcTerrainWindow : UserControl
    {
        SGWorld70 pSgWorld = null;
        PictureBox pic = null;
        public UcTerrainWindow()
        {
            InitializeComponent();
            pic = new PictureBox();
            pic.Dock = DockStyle.Fill;
            this.Controls.Add(pic);
        }
        public void Init()
        {
            pSgWorld = new SGWorld70Class();

            pSgWorld.OnLoadFinished += PSgWorld_OnLoadFinished;
            pSgWorld.OnFileClosed += PSgWorld_OnFileClosed;

        }
        private void PSgWorld_OnFileClosed()
        {
        }

        private void PSgWorld_OnLoadFinished(bool bSuccess)
        {
            if (pSgWorld.Terrain.Name == "NO_MPT")
                pic.Visible = true;
            else
                pic.Visible = false;
        }

        private void UcTerrainWindow_Load(object sender, EventArgs e)
        {
        }
        #region skyline菜单功能实现
        public void OpenProject(string url = "")
        {
            pSgWorld.Command.Execute((int)SkylineCommandCode.CommandIDCode.ID_OpenProject, url);
        }
        public void OpenDefaultProject()
        {
            pSgWorld.Project.Open(Application.StartupPath + @"\Default.fly", true);
        }
        public void MeasureArea()
        {
            pSgWorld.Command.Execute((int)SkylineCommandCode.CommandIDCode.ID_MeasureTerraArea, (int)SkylineCommandCode.CommandOptions.OP_MeasureTerraArea);
        }
        public void MeasureDistance()
        {
            pSgWorld.Command.Execute((int)SkylineCommandCode.CommandIDCode.ID_AerialDistance, (int)SkylineCommandCode.CommandOptions.OP_VerticalDistance);
        }
        #endregion
    }
}
