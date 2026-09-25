using System;
using System.Collections.Generic;
using System.IO;
using Wintellect.PowerCollections;
using XRL.Core;
using XRL.Rules;
using XRL.UI;
using XRL.World.Parts;

namespace XRL.World.ZoneBuilders {

    public class UrsaRemoveDirtyWidget {

        public bool BuildZone(Zone Z)
        {
            // I need to write my own widget that will clear grass and add concrete floor later
            // this is a super dumb way of doing this but its kinda funny
            Z.GetFirstObject("Dirty")?.Destroy();
            Z.GetFirstObject("Grassy")?.Destroy();
            // GameObject concrete = Z.GetCell(0, 0).AddObject("ConcreteFloor");
            // ConcreteFloor concpainter = concrete.GetPart<ConcreteFloor>();
            for (int i = 0; i < Z.Height; i++)
            {
                for (int j = 0; j < Z.Width; j++)
                {
                    Cell cell = Z.Map[j][i];
                    CrystalDirty.PaintCell(cell);
                }
            }
            return true;
        }
    }
}