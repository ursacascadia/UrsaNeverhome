using System;
using System.Collections.Generic;
using XRL;
using XRL.World;
using XRL.World.Conversations;
using XRL.Messages;
using XRL.World.Parts;

namespace UrsaNeverhome {

[HasConversationDelegate]
public static class UrsaDelegates
    {
        // Activate objects with tag "DestroyAndReplaceWith"
        [ConversationDelegate]
        public static void RunDestroyAndReplace(DelegateContext Context)
        {
            foreach (GameObject obj in The.ActiveZone.FindObjectsWithTagOrProperty("DestroyAndReplaceWith")) {
                string blueprint = obj?.GetTagOrStringProperty("DestroyAndReplaceWith") ?? "";
                if (blueprint != "") {
                    obj.CurrentCell.AddObject(blueprint);
                }
                obj.Destroy();
            }
        }

        // Find Agnosi and trigger his quest finishing part
        [ConversationDelegate]
        public static void FinishAgnosiQuest(DelegateContext Context)
        {
            List<GameObject> objlist = The.ActiveZone.FindObjectsWithPart("UrsaAgnosi");
            if (objlist?.Count != 0 && objlist[0] != null)
            {
                GameObject agnosi = objlist[0];
                if (agnosi.CurrentCell.X > 18 && agnosi.CurrentCell.X < 30)
                {
                    if (agnosi.CurrentCell.Y > 7 && agnosi.CurrentCell.Y < 17)
                    {
                        agnosi.GetPart<UrsaAgnosi>()?.Trigger();
                    }
                }
            }
        }
    }
}