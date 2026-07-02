using System;
using System.Collections.Generic;
using System.Linq;
using Genkit;
using UnityEngine;
using XRL.EditorFormats.Map;
using XRL.Rules;
using XRL.UI;

namespace XRL.World.ZoneBuilders {

public class UrsaNeverhomeCatacombs : ZoneBuilderSandbox
{
    public bool BuildZone(Zone Z)
    {
        if (Z.ZoneID == "JoppaWorld.53.3.2.2.11"){
            Z.GetEmptyCells().GetRandomElement().AddObject("Ursa_Urahiah");
        }
        return true;
    }
}

}