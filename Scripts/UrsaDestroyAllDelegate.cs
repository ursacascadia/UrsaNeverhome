using XRL;
using XRL.World;
using XRL.World.Conversations;
using XRL.Messages;

namespace UrsaCompanionHelpers {

[HasConversationDelegate]
public static class UrsaDelegates
{
    // Destroy all objects in the current zone with the specified tag
    [ConversationDelegate]
    public static void DestroyAll(DelegateContext Context)
    {
        foreach (var destroy_object in The.ActiveZone.FindObjectsWithTagOrProperty(Context.Value)) {
            destroy_object.Destroy();
        }
    }
}

}