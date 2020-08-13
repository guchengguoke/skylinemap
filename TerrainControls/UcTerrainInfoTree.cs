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
    public partial class UcTerrainInfoTree : UserControl
    {
        SGWorld70 pSgWorld = null;
        public UcTerrainInfoTree()
        {
            InitializeComponent();
        }
        public void Init()
        {
            pSgWorld = new SGWorld70Class();
            //if (pSgWorld.Terrain.Name == "NO_MPT")
            //    pictureBox_TreeCompanyInfo.Visible = true;
            //else
            //    pictureBox_TreeCompanyInfo.Visible = false;
            pSgWorld.OnLoadFinished += PSgWorld_OnLoadFinished;
            pSgWorld.OnFileClosed += PSgWorld_OnFileClosed;

        }
        private void PSgWorld_OnFileClosed()
        {
        }

        private void PSgWorld_OnLoadFinished(bool bSuccess)
        {
        }

        private void UcTerrainInfoTree_Load(object sender, EventArgs e)
        {
            
        }
    }
}
