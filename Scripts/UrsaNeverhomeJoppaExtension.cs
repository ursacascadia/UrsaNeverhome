using Genkit;
using System;
using XRL;
using XRL.World;
using XRL.World.Parts;
using XRL.World.WorldBuilders;
using XRL.World.ZoneBuilders;

namespace Ursa.Neverhome
{
    [JoppaWorldBuilderExtension]
    public class UrsaNeverhomeJoppaExtension : IJoppaWorldBuilderExtension
    {

        public override void OnAfterBuild(JoppaWorldBuilder builder)
        {
            Zone WorldZone = The.ZoneManager.GetZone("JoppaWorld");
            MutabilityMap mutableMap = builder.mutableMap;

            // Place Urahiah in the bottom right of the folk catacombs
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.2.2.11", "UrsaNeverhomeCatacombs");

            // Place stairs down to the lab
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.14", "StairsDown", "x", 34, "y", 16);

            // ### Lab maps

            // Static map 1
            string current_zone = "JoppaWorld.53.3.1.1.15";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "MapBuilder", "FileName", "Ursa_LabEntryway.rpm");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp", "x", 34, "y", 16);
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown", "x", 73, "y", 15);
            The.ZoneManager.SetZoneName(current_zone, "antechamber", "Neverhome", null, null, null, Proper: false);
            // Static map 2
            current_zone = "JoppaWorld.53.3.1.1.16";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "MapBuilder", "FileName", "Ursa_LabEntryway2.rpm");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp", "x", 73, "y", 15);
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown", "x", 5, "y", 13);
            The.ZoneManager.SetZoneName(current_zone, "surgical theatre", "Neverhome", null, null, null, Proper: false);

            // Proc gen dungeon floor
            current_zone = "JoppaWorld.53.3.1.1.17";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.ClearZoneBuilders(current_zone);
            The.ZoneManager.AddZoneBuilder(current_zone, 0, "ClearAll");
            The.ZoneManager.AddZoneBuilder(current_zone, 4900, "SolidEarth");
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "UrsaTileBuilding");
            The.ZoneManager.AddZoneBuilder(current_zone, 5100, "UrsaRemoveDirtyWidget"); // this does a lot more than it says on the tin lol
            // The.ZoneManager.AddZoneBuilder(current_zone, 5200, "AddWidgetBuilder", "Blueprint", "ConcreteFloor"); // removed since the dirty widget sets it
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp", "x", 5, "y", 13);
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown");
            The.ZoneManager.AddZonePostBuilder(current_zone, "Connecter");
            The.ZoneManager.SetZoneName(current_zone, "scrawling halls", "Neverhome", null, null, null, Proper: false);
            // Proc gen dungeon floor
            current_zone = "JoppaWorld.53.3.1.1.18";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.ClearZoneBuilders(current_zone);
            The.ZoneManager.AddZoneBuilder(current_zone, 0, "ClearAll");
            The.ZoneManager.AddZoneBuilder(current_zone, 4900, "SolidEarth");
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "UrsaTileBuilding");
            The.ZoneManager.AddZoneBuilder(current_zone, 5100, "UrsaRemoveDirtyWidget");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown");
            The.ZoneManager.AddZonePostBuilder(current_zone, "Connecter");
            The.ZoneManager.SetZoneName(current_zone, "scrawling halls", "Neverhome", null, null, null, Proper: false);

            // Static map 3
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.19");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.19", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.19", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.19", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.19", "etching bank", null, null, null, null, Proper: false);

            // Proc gen dungeon floor
            current_zone = "JoppaWorld.53.3.1.1.20";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.ClearZoneBuilders(current_zone);
            The.ZoneManager.AddZoneBuilder(current_zone, 0, "ClearAll");
            The.ZoneManager.AddZoneBuilder(current_zone, 4900, "SolidEarth");
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "UrsaTileBuilding");
            The.ZoneManager.AddZoneBuilder(current_zone, 5100, "UrsaRemoveDirtyWidget");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown");
            The.ZoneManager.AddZonePostBuilder(current_zone, "Connecter");
            The.ZoneManager.SetZoneName(current_zone, "prolixity chambers", "Neverhome", null, null, null, Proper: false);

            // Static map 4
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.21");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.21", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.21", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.21", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.21", "antecedent den", "Neverhome", null, null, null, Proper: false);

            // Proc gen dungeon floor
            current_zone = "JoppaWorld.53.3.1.1.22";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.ClearZoneBuilders(current_zone);
            The.ZoneManager.AddZoneBuilder(current_zone, 0, "ClearAll");
            The.ZoneManager.AddZoneBuilder(current_zone, 4900, "SolidEarth");
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "UrsaTileBuilding");
            The.ZoneManager.AddZoneBuilder(current_zone, 5100, "UrsaRemoveDirtyWidget");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown");
            The.ZoneManager.AddZonePostBuilder(current_zone, "Connecter");
            The.ZoneManager.SetZoneName(current_zone, "notionary hollows", "Neverhome", null, null, null, Proper: false);
            // Proc gen dungeon floor
            current_zone = "JoppaWorld.53.3.1.1.23";
            The.ZoneManager.SetZoneProperty(current_zone, "SkipTerrainBuilders", true);
            The.ZoneManager.ClearZoneBuilders(current_zone);
            The.ZoneManager.AddZoneBuilder(current_zone, 0, "ClearAll");
            The.ZoneManager.AddZoneBuilder(current_zone, 4900, "SolidEarth");
            The.ZoneManager.AddZoneBuilder(current_zone, 5000, "UrsaTileBuilding");
            The.ZoneManager.AddZoneBuilder(current_zone, 5100, "UrsaRemoveDirtyWidget");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsUp");
            The.ZoneManager.AddZonePostBuilder(current_zone, "StairsDown");
            The.ZoneManager.AddZonePostBuilder(current_zone, "Connecter");
            The.ZoneManager.SetZoneName(current_zone, "notionary hollows", "Neverhome", null, null, null, Proper: false);

            // Static map 5
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.24");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.24", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.24", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.24", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.24", "oscillatory antre", "Nowhome", null, null, null, Proper: false);
            // Static map 6
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.25");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.25", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.25", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.25", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.25", "palimpsest vault", "Nowhome", null, null, null, Proper: false);
            // Static map 7 (Ending)
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.26");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.26", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.26", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.26", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.25", "juvenilian shadow", "Nowhome", null, null, null, Proper: true);
        }

    }
}
