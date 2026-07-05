using System;
using XRL;
using XRL.Core;
using XRL.World;

namespace XRL.World.Parts {

    [Serializable]
    public class UrsaSpawnsWithRelic : IPart
    {
        public int RelicCount = 1;
        public int TierFrom = 1;
        public int TierTo = 3;

        public override bool WantEvent(int ID, int cascade)
        {
            return base.WantEvent(ID, cascade)
                || ID == ObjectCreatedEvent.ID;
        }

        public override bool HandleEvent(ObjectCreatedEvent E)
        {
            Random rnd = new Random();
            for (int i = 0; i < RelicCount; i++) {
                ParentObject.ReceiveObject(RelicGenerator.GenerateRelic(rnd.Next(TierFrom, TierTo), true));
            }
            return base.HandleEvent(E);
        }
    }

}