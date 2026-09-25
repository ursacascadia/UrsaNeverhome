using System;
using System.Collections.Generic;
using System.IO;
using Wintellect.PowerCollections;
using XRL.Core;
using XRL.Rules;
using XRL.UI;

namespace XRL.World.ZoneBuilders {

[HasModSensitiveStaticCache]
public class UrsaTileBuilding : TileBuilding
    {
        // public string WallMaterial = "Ursa_LabWall";

        // public string ShellMaterial = "Fulcrete";

        // public bool Shell = true;

        // public int Wide = 13;

        // public int High = 4;

        // public int XCorner = 10;

        // public int YCorner = 2;

        // public string TileStartMarker = "6Tiles";

        // public string TileEndMarker = "6TilesEnd";

        // public int NumberOfVaults = 4;

        // public int ChancePerVault = 13;

        // public int VaultWidth = 2;

        // public int VaultHeight = 2;

        // public string VaultStartMarker = "BethVaults";

        // public string VaultEndMarker = "BethVaultsEnd";

        // public int NumberOfVaults2 = 2;

        // public int ChancePerVault2 = 30;

        // public int VaultWidth2 = 2;

        // public int VaultHeight2 = 2;

        // public string VaultStartMarker2 = "BathVaults";

        // public string VaultEndMarker2 = "BathVaultsEnd";

        public UrsaTileBuilding()
        {
            WallMaterial = "Ursa_LabWall";

            ShellMaterial = "Fulcrete";

            Shell = true;

            Wide = 14;

            High = 4;

            XCorner = 4;

            YCorner = 2;

            TileStartMarker = "6Tiles";

            TileEndMarker = "6TilesEnd";

            NumberOfVaults = 0;

            ChancePerVault = 13;

            VaultWidth = 2;

            VaultHeight = 2;

            VaultStartMarker = "BethVaults";

            VaultEndMarker = "BethVaultsEnd";

            NumberOfVaults2 = 0;

            ChancePerVault2 = 0;

            VaultWidth2 = 2;

            VaultHeight2 = 2;

            VaultStartMarker2 = "BathVaults";

            VaultEndMarker2 = "BathVaultsEnd";
        }

    }

}