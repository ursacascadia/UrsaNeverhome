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
            The.ZoneManager.AddZonePostBuilder("JoppaWorld.53.3.1.1.14","StairsDown");
        }

    }
}