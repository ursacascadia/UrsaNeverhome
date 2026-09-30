using XRL;
using XRL.World;
using XRL.World.Conversations;
using XRL.Messages;

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
    }
}