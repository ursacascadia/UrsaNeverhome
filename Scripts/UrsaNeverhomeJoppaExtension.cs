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
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.15");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.15", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.15", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.15", "MapBuilder", "FileName", "Ursa_LabEntryway.rpm");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.15", "", null, null, null, null, Proper: false);
            // Static map 2
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.16");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.16", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.16", 4900, "ClearAll");
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.16", 5000, "MapBuilder", "FileName", "Ursa_LabEntryway2.rpm");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.16", "", null, null, null, null, Proper: false);

            // Proc gen dungeon floor
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.17", "Ursa_NeverhomeGenerator");
            // Proc gen dungeon floor
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.18", "Ursa_NeverhomeGenerator");

            // Static map 3
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.19");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.19", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.19", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.19", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.19", "", null, null, null, null, Proper: false);

            // Proc gen dungeon floor
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.20", "Ursa_NeverhomeGenerator");

            // Static map 4
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.21");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.21", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.21", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.21", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.21", "", null, null, null, null, Proper: false);

            // Proc gen dungeon floor
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.22", "Ursa_NeverhomeGenerator");
            // Proc gen dungeon floor
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.23", "Ursa_NeverhomeGenerator");

            // Static map 5
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.24");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.24", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.24", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.24", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.24", "", null, null, null, null, Proper: false);
            // Static map 6
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.25");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.25", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.25", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.25", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.25", "", null, null, null, null, Proper: false);
            // Static map 7 (Ending)
            The.ZoneManager.ClearZoneBuilders("JoppaWorld.53.3.1.1.26");
            The.ZoneManager.SetZoneProperty("JoppaWorld.53.3.1.1.26", "SkipTerrainBuilders", true);
            The.ZoneManager.AddZoneBuilder("JoppaWorld.53.3.1.1.26", 4900, "ClearAll");
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.26", "MapBuilder", "FileName", "");
            The.ZoneManager.SetZoneName("JoppaWorld.53.3.1.1.26", "", null, null, null, null, Proper: false);
        }

    }
}
