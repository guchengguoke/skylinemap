using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TerraExplorerX;

namespace SkylineMap
{
    public class SkylineCommandCode
    {
        public enum CommandIDCode
        {
            //project
            ID_OpenProject = 1001,
            ID_OpenSearchCatalog = 1143,
            ID_Save = 1003,
            ID_SaveAs = 1004,
            ID_Close = 1005,
            ID_Print = 1152,

            ID_SelectObject = 1021,
            ID_Properties = 1022,
            ID_SelectArea = 1024,
            ID_Paste = 1030,
            ID_Copy = 1031,
            ID_Cut = 1032,
            ID_Delete = 1033,

            ID_Play = 1112,
            ID_Stop = 1113,

            //2D objects
            ID_2DPolyline = 1012,
            ID_2DPolygon = 1012,
            ID_2DRectangle = 1012,
            ID_2DRegularPolygon = 1012,
            ID_2DArrow = 1012,
            ID_2DCircle = 1012,
            ID_2DEllipse = 1012,
            ID_2DArc = 1012,

            //3D objects
            ID_TextLabel = 1012,
            ID_ImageLabel = 1012,
            ID_VideoOnTerrain = 1012,
            ID_VideoOnBillboard = 1012,
            ID_3DModel = 1012,
            ID_3DBuilding = 1012,
            ID_3DModifyTerrain = 1012,
            ID_3DHoleOnTerrain = 1012,
            ID_3DPolygon = 1012,
            ID_3DBox = 1012,
            ID_3DCylinder = 1012,
            ID_3DSphere = 1012,
            ID_3DCone = 1012,
            ID_3DPyramid = 1012,
            ID_3DArrow = 1012,
            ID_3DPointCloudModel = 1012,
            ID_3DLinearPointCloudset = 1012,
            ID_GroundVehicle = 1012,
            ID_AerialVehicle = 1012,

            ID_Location = 1016,
            ID_TreeMessage = 1017,
            ID_NewInformationTreeGroup = 1018,
            ID_CaptureTreeState = 1019,

            //Analysis
            ID_InformationQuery = 1023,
            ID_HorizontalDistance = 1034,
            ID_AerialDistance = 1035,
            ID_VerticalDistance = 1036,
            ID_MeasureTerraArea = 1165,
            ID_Measure3DArea = 1037,
            ID_ContourMap = 1040,
            ID_BestPath = 1042,
            ID_TerrainProfile = 1043,
            ID_FloodAnalysis = 1044,
            ID_VolumeAnalysis = 1045,
            ID_LineOfSight = 1046,
            ID_ViewshedAnalysis = 1047,
            ID_ThreatDome = 1048,
            ID_SlopeAnalysis = 1094,
            ID_ShadowAnalysis = 1149,

            //navigation
            ID_DragMode = 1049,
            ID_SlideMode = 1050,
            ID_TurnandTiltMode = 1051,

            ID_3DMode = 1052,
            ID_2DNavigationMode = 1053,
            ID_2DNorthNavigationMode = 1054,

            ID_House = 1055,
            ID_Street = 1055,
            ID_City = 1055,
            ID_State = 1055,
            ID_Country = 1055,
            ID_Globe = 1055,

            ID_FaceNorth = 1056,
            ID_FlyAround = 1057,

            ID_CirclePattern = 1057,
            ID_OvalPattern = 1057,
            ID_LinePattern = 1057,
            ID_ArcPattern = 1057,

            ID_BehindObject = 1057,
            ID_AboveObject = 1057,
            ID_FromBelow = 1057,
            ID_FromRight = 1057,
            ID_FromLeft = 1057,
            ID_FromBehindandabove = 1057,
            ID_CockpitView = 1057,
            ID_FromGroundpoint = 1057,

            //view
            ID_Options = 1011,
            ID_ProjectSettings = 1020,
            ID_UseSun = 1026,
            ID_UndergroundMode = 1027,
            ID_NavigationMapSettings = 1058,
            ID_HideTerrain = 1059,
            ID_CollisionDetection = 1140,
            ID_IndoorViews = 1149,
            ID_ShowClouds = 1154,
            ID_ShowWater = 1155,
            ID_TerrainOpacity = 1060,
            ID_NavigationControls = 1065,
            ID_CenterSign = 1065,
            ID_StatusBar = 1065,
            ID_ScaleBar = 1065,
            ID_TimeSlider = 1065,
            ID_GraphicHUD = 1065,
            ID_NavigationMap = 1161,
            ID_ProjectTree = 1162,

            //layer
            ID_DataLibraryLayers = 1013,
            ID_LoadTerraExplorerProject = 1013,
            ID_LoadGoogleEarthLayer = 1013,
            ID_LoadFeatureLayer = 1013,
            ID_LoadImageryLayer = 1014,
            ID_LoadElevationLayer = 1014,
            ID_Attributes_Table = 1086,
            ID_RefreshLayer = 1087,
            ID_SaveLayer = 1088,
            ID_SaveAsLayer = 1089,

            //tools
            ID_Snapshot = 1067,
            ID_SaveSnapshotToFile = 1068,

            ID_ExtractToMPT = 1141,
            ID_GPSTracking = 1149,
            ID_Target = 1149,
            ID_MultipleCoordinateSystems = 1149,
            ID_Collaboration = 1149,
            ID_Draw = 1149,
            ID_Duplicate_Objects = 1149,
            ID_PowerLines = 1149,
            ID_PipeLines = 1149,
            ID_TimespanTags = 1149,
            ID_MakeCPT = 1149,
            ID_MakeXPL = 1149,
            ID_ResolutionPyramid = 1149,
            ID_DataLibrary = 1149,
            ID_GoogleWarehouse = 1149,
            ID_BlockWidth = 1149,
            ID_FenceAndWall = 17
        };
        public enum CommandOptions
        {
            //project
            OP_OpenProject = 0,
            OP_OpenSearchCatalog = 0,
            OP_Save = 0,
            OP_SaveAs = 0,
            OP_Close = 0,
            OP_Print = 0,

            OP_SelectObject = 0,
            OP_Properties = 0,
            OP_SelectArea = 0,
            OP_Paste = 0,
            OP_Copy = 0,
            OP_Cut = 0,
            OP_Delete = 0,

            OP_Play = 0,
            OP_Stop = 0,

            //2D objects
            OP_2DPolyline = 4,
            OP_2DPolygon = 5,
            OP_2DRectangle = 6,
            OP_2DRegularPolygon = 7,
            OP_2DArrow = 8,
            OP_2DCircle = 9,
            OP_2DEllipse = 10,
            OP_2DArc = 11,

            //3D objects
            OP_TextLabel = 0,
            OP_ImageLabel = 1,
            OP_VideoOnTerrain = 2,
            OP_VideoOnBillboard = 3,
            OP_3DModel = 13,
            OP_3DBuilding = 14,
            OP_3DModifyTerrain = 15,
            OP_3DHoleOnTerrain = 16,
            OP_3DPolygon = 17,
            OP_3DBox = 18,
            OP_3DCylinder = 20,
            OP_3DSphere = 21,
            OP_3DCone = 22,
            OP_3DPyramid = 23,
            OP_3DArrow = 24,
            OP_3DPointCloudModel = 25,
            OP_3DLinearPointCloudset = 35,
            OP_GroundVehicle = 26,
            OP_AerialVehicle = 27,

            OP_Location = 0,
            OP_TreeMessage = 0,
            OP_NewInformationTreeGroup = 0,
            OP_CaptureTreeState = 0,

            //Analysis
            OP_InformationQuery = 0,
            OP_HorizontalDistance = 0,
            OP_AerialDistance = 0,
            OP_VerticalDistance = 0,
            OP_MeasureTerraArea = 0,
            OP_Measure3DArea = 0,
            OP_ContourMap = 0,
            OP_BestPath = 0,
            OP_TerrainProfile = 0,
            OP_FloodAnalysis = 0,
            OP_VolumeAnalysis = 0,
            OP_LineOfSight = 0,
            OP_ViewshedAnalysis = 0,
            OP_ThreatDome = 0,
            OP_SlopeAnalysis = 0,
            OP_Shadow_Analysis = 14,

            //navigation
            OP_DragMode = 0,
            OP_SlideMode = 0,
            OP_TurnandTiltMode = 0,

            OP_3DMode = 0,
            OP_2DNavigationMode = 0,
            OP_2DNorthNavigationMode = 0,

            OP_House = 0,
            OP_Street = 1,
            OP_City = 2,
            OP_State = 3,
            OP_Country = 4,
            OP_Globe = 5,

            OP_FaceNorth = 0,
            OP_FlyAround = 0,

            OP_CirclePattern = 0,
            OP_OvalPattern = 1,
            OP_LinePattern = 2,
            OP_ArcPattern = 3,

            OP_BehindObject = 4,
            OP_AboveObject = 5,
            OP_FromBelow = 6,
            OP_FromRight = 7,
            OP_FromLeft = 8,
            OP_FromBehindandabove = 9,
            OP_CockpitView = 10,
            OP_FromGroundpoint = 11,

            //view
            OP_Options = 0,
            OP_ProjectSettings = 0,
            OP_UseSun = 0,
            OP_UndergroundMode = 0,
            OP_NavigationMapSettings = 0,
            OP_HideTerrain = 0,
            OP_CollisionDetection = 0,
            OP_IndoorViews = 0,
            OP_ShowClouds = 0,
            OP_ShowWater = 0,
            OP_TerrainOpacity = 0,
            OP_NavigationControls = 0,
            OP_CenterSign = 1,
            OP_StatusBar = 2,
            OP_ScaleBar = 3,
            OP_TimeSlider = 4,
            OP_GraphicHUD = 5,
            OP_NavigationMap = 0,
            OP_ProjectTree = 0,

            //layer
            OP_DataLibraryLayers = 0,
            OP_LoadTerraExplorerProject = 2,
            OP_LoadGoogleEarthLayer = 3,
            OP_LoadFeatureLayer = 5,
            OP_LoadImageryLayer = 2,
            OP_LoadElevationLayer = 19,
            OP_Attributes_Table = 0,
            OP_RefreshLayer = 0,
            OP_SaveLayer = 0,
            OP_SaveAsLayer = 0,

            //tools
            OP_Snapshot = 0,
            OP_SaveSnapshotToFile = 0,

            OP_ExtractToMPT = 0,
            OP_GPSTracking = 1,
            OP_Target = 2,
            OP_MultipleCoordinateSystems = 3,
            OP_Collaboration = 4,
            OP_Draw = 5,
            OP_Duplicate_Objects = 6,
            OP_PowerLines = 7,
            OP_PipeLines = 8,
            OP_TimespanTags = 9,
            OP_MakeCPT = 10,
            OP_MakeXPL = 11,
            OP_ResolutionPyramid = 12,
            OP_DataLibrary = 13,
            OP_GoogleWarehouse = 15,
            OP_BlockWidth = 16,
            OP_FenceAndWall = 17
        };
    }
}
