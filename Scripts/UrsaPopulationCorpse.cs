using System;
using System.Collections.Generic;
using XRL;
using XRL.Core;

namespace XRL.World.Parts {

    [Serializable]
    public class UrsaPopulationCorpse : IPart
    {

        public string PopulationName;

        public override bool WantEvent(int ID, int cascade)
        {
            if (!base.WantEvent(ID, cascade))
            {
                return ID == BeforeDeathRemovalEvent.ID;
            }
            return true;
        }

        public override bool HandleEvent(BeforeDeathRemovalEvent E)
        {
            // XRL.UI.Popup.Show("Cryotube getting splodes");
            ParentObject.CurrentCell.AddPopulation(PopulationName);
            return base.HandleEvent(E);
        }
    }

}