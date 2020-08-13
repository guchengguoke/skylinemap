using SkylineMap.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TerraExplorerX;
namespace SkylineMap
{
    public partial class FrmMain : Form
    {
        TerrainControls.UcTerrainWindowEx ucTerrainWindowEx = null;
        TerrainControls.UcTerrainWindow ucTerrainWindow = null;
        TerrainControls.UcTerrainInfoTree ucTerrainInfoTree = null;
        SGWorld70 sgWorld70;
        public FrmMain()
        {
            InitializeComponent();
            InitControl();
            sgWorld70 = new SGWorld70Class();
        }
        void InitControl()
        {
            ucTerrainWindowEx = new TerrainControls.UcTerrainWindowEx();
            panel_Map3DEx.Controls.Add(ucTerrainWindowEx);
            ucTerrainWindowEx.Dock = DockStyle.Fill;
            ucTerrainWindow = new TerrainControls.UcTerrainWindow();
            panel_Map3D.Controls.Add(ucTerrainWindow);
            ucTerrainWindow.Dock = DockStyle.Fill;
            ucTerrainInfoTree = new TerrainControls.UcTerrainInfoTree();
            panel_Left.Controls.Add(ucTerrainInfoTree);
            ucTerrainInfoTree.Dock = DockStyle.Fill;
        }
        private void panel_Main_Resize(object sender, EventArgs e)
        {
            if (panel_Map3DEx.Visible)
            {
                panel_Map3D.Width = panel_Main.Width / 2;
                panel_Map3DEx.Width = panel_Main.Width / 2;
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            ucTerrainWindow.Init();
            ucTerrainWindowEx.Init(sgWorld70);
        }

        private void button_OpenEx_Click(object sender, EventArgs e)
        {
            if (button_OpenEx.Text == "两球分屏")
            {
                panel_Map3DEx.Visible = true;
                button_OpenEx.Text = "显示一球";
            }
            else
            {
                panel_Map3DEx.Visible = false;
                button_OpenEx.Text = "两球分屏";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucTerrainWindow.OpenDefaultProject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucTerrainWindow.MeasureArea();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sgWorld70.Command.Execute(1054, 0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ucTerrainWindowEx.OpenDefaultProject();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sgWorld70.Project.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var itemID = sgWorld70.ProjectTree.FindItem("测试组");
            itemID = sgWorld70.ProjectTree.GetNextItem(itemID, ItemCode.CHILD);
            while (itemID != "")
            {
                var itemName = sgWorld70.ProjectTree.GetItemName(itemID);
                richTextBox1.AppendText(itemName + "\r\n");
                itemID = sgWorld70.ProjectTree.GetNextItem(itemID, ItemCode.NEXT);
            }
        }

        private void checkBox_Rain_CheckedChanged(object sender, EventArgs e)
        {
            sgWorld70.Command.Execute(2206, checkBox_Rain.Checked ? 1 : 0);
        }

        private void button_dynamicObject_Click(object sender, EventArgs e)
        {
            Class.WeatherHelper weather = new Class.WeatherHelper(sgWorld70);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                weather.CreateWeatherObjectFormTxt(System.IO.File.ReadAllLines(openFileDialog.FileName), System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName));
            }
        }

        private void button_ReadDynamicXY_Click(object sender, EventArgs e)
        {
            DynamicObjectRoute dynamicObjectRoute = new DynamicObjectRoute(sgWorld70);
            string itemID = sgWorld70.ProjectTree.FindItem("南京航空航天大学\\飞行路径\\波音747");
            DataTable dt = dynamicObjectRoute.GetRoutePointList(itemID);
            dataGridView1.DataSource = dt;
        }
    }
}
