using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraExplorerX;
using System.Data;
namespace SkylineMap.Class
{
    class DynamicObjectRoute
    {
        SGWorld70 sgWorld;
        public DynamicObjectRoute(SGWorld70 sgWorld70)
        {
            sgWorld = sgWorld70;
        }
        public  DataTable GetRoutePointList(string objetID)
        {
            DataTable dtPoint = new DataTable();
            DataColumn column = new DataColumn("X");
            dtPoint.Columns.Add(column);
            column = new DataColumn("Y");
            dtPoint.Columns.Add(column);
            column = new DataColumn("Altitude");
            dtPoint.Columns.Add(column);
            column = new DataColumn("TimeSpan");
            dtPoint.Columns.Add(column);
            column = new DataColumn("Roll");
            dtPoint.Columns.Add(column);
            column = new DataColumn("Pitch");
            dtPoint.Columns.Add(column);
            column = new DataColumn("Yaw");
            dtPoint.Columns.Add(column);
            column = new DataColumn("Speed");
            dtPoint.Columns.Add(column);
            ITerrainDynamicObject70 dynamic = sgWorld.ProjectTree.GetObject(objetID) as ITerrainDynamicObject70;
            if (dynamic == null) return null;
            IRouteWaypoints70 points = dynamic.Waypoints;
            DataRow dr = null;
            IPosition70 posPre = null;
            IPosition70 posCurrent = null;
            IPosition70 posNext = null;
            double timeSpan = 0;
            for (int i = 0; i < points.Count; i++)
            {
                dr = dtPoint.NewRow();
                //pointInfo = new RoutePointInfo();
                dr["X"] = points.GetWaypoint(i).X.ToString("0.000000");
                dr["Y"] = points.GetWaypoint(i).Y.ToString("0.000000");
                dr["Altitude"] = points.GetWaypoint(i).Altitude.ToString("0.000000");
                if (i != 0)
                    posPre = sgWorld.Creator.CreatePosition(points.GetWaypoint(i - 1).X, points.GetWaypoint(i - 1).Y, points.GetWaypoint(i - 1).Altitude);
                posCurrent = sgWorld.Creator.CreatePosition(points.GetWaypoint(i).X, points.GetWaypoint(i).Y, points.GetWaypoint(i).Altitude);
                if (i == 0)
                {
                    dr["TimeSpan"] = 0;
                }
                else
                {
                    timeSpan = posCurrent.DistanceTo(posPre) / points.GetWaypoint(i).Speed + timeSpan;
                    dr["TimeSpan"] = timeSpan.ToString("0.000");
                }
                if (i != (points.Count - 1))
                {
                    posNext = sgWorld.Creator.CreatePosition(points.GetWaypoint(i + 1).X, points.GetWaypoint(i + 1).Y, points.GetWaypoint(i + 1).Altitude);
                    dr["Roll"] = Convert.ToDouble(posCurrent.AimTo(posNext).Roll.ToString().ToString()).ToString("0.0");
                    dr["Pitch"] = Convert.ToDouble(posCurrent.AimTo(posNext).Pitch.ToString().ToString()).ToString("0.0");
                    dr["Yaw"] = Convert.ToDouble(posCurrent.AimTo(posNext).Yaw.ToString().ToString()).ToString("0.0");
                }
                else
                {
                    dr["Roll"] = Convert.ToDouble(dtPoint.Rows[i - 1]["Roll"].ToString()).ToString("0.0");
                    dr["Pitch"] = Convert.ToDouble(dtPoint.Rows[i - 1]["Pitch"].ToString()).ToString("0.0");
                    dr["Yaw"] =Convert.ToDouble(dtPoint.Rows[i - 1]["Yaw"].ToString()).ToString("0.0");
                }
                //if (i == points.Count - 1)
                //{
                //    dr["TimeSpan"] = 0;
                //}
                dr["Speed"] = Math.Round(points.GetWaypoint(i).Speed*3.6).ToString();
                dtPoint.Rows.Add(dr);
                //pointList.Add(pointInfo);
            }
            return dtPoint;
        }
    }
}
