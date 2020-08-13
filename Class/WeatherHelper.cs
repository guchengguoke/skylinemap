using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraExplorerX;
namespace SkylineMap.Class
{
    class WeatherHelper
    {
        SGWorld70 sgWorld;
        public WeatherHelper(SGWorld70 sgWorld70)
        {
            sgWorld = sgWorld70;
        }
        public void CreateWeatherObjectFormTxt(string[] weatherInfoArr, string groupName)
        {
            IPosition70 pos = null;
            double lon, lat, altitude;
            string[] weatherInfo;
            string imagePath = "";
            ILabelStyle70 labelStyle = null;
            string groupID = GetWeatherGroup(groupName);
            double scale = 500;
            double minHeight = 30000;
            for (int i = 1; i < weatherInfoArr.Length; i++)
            {
                weatherInfo = weatherInfoArr[i].Split(' ');
                lon = Convert.ToDouble(weatherInfo[3]);
                lat = Convert.ToDouble(weatherInfo[4]);
                altitude = Convert.ToDouble(weatherInfo[5]);
                if (weatherInfo.Length > 6)
                    scale = Convert.ToDouble(weatherInfo[6]);
                if (weatherInfo.Length > 7)
                    minHeight = Convert.ToDouble(weatherInfo[7]);
                labelStyle = sgWorld.Creator.CreateLabelStyle(SGLabelStyle.LS_DEFAULT);
                labelStyle.Scale = scale;
                labelStyle.PivotAlignment = "Top,Center";
                labelStyle.MinViewingHeight = minHeight;
                pos = sgWorld.Creator.CreatePosition(lon, lat, altitude);
                imagePath = System.Windows.Forms.Application.StartupPath + @"\Data\Weather\" + weatherInfo[1] + ".gif";
                if (!System.IO.File.Exists(imagePath))
                    imagePath = System.Windows.Forms.Application.StartupPath + @"\Data\Weather\" + weatherInfo[1] + ".png";
                if (!System.IO.File.Exists(imagePath)) continue;
                ITerrainImageLabel70 imageLabel = sgWorld.Creator.CreateImageLabel(pos, imagePath, labelStyle, groupID, weatherInfo[0]);
                imageLabel.Tooltip.Text = weatherInfo[1] + "\r\n" + weatherInfo[2];
            }
        }
        public string GetWeatherGroup(string groupName)
        {
            string groupID = sgWorld.ProjectTree.FindItem("南京航空航天大学\\空间仿真要素\\气象3D模型\\" + groupName + "");
            if (groupID != "")
            {
                sgWorld.ProjectTree.DeleteItem(groupID);
            }
            groupID = sgWorld.ProjectTree.FindItem("南京航空航天大学\\空间仿真要素\\气象3D模型");
            groupID = sgWorld.ProjectTree.CreateGroup(groupName, groupID);
            sgWorld.ProjectTree.LockGroup(groupID, true);
            return groupID;
        }
    }
}
