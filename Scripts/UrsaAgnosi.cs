using System;

namespace XRL.World.Parts {

[Serializable]
public class UrsaAgnosi : IPart
{
    public string Quest = "To Die, to Sleep";

    public string Step = "Put Agnosi to rest";

    public string GameState = "Ursa_KilledAgnosi";

    public virtual bool Clean => true;

    public override bool WantEvent(int ID, int cascade)
    {
        if (!base.WantEvent(ID, cascade) && ID != ReplicaCreatedEvent.ID && ID != AfterDieEvent.ID)
        {
            return ID == PooledEvent<ReplaceInContextEvent>.ID;
        }
        return true;
    }

    public override bool HandleEvent(ReplicaCreatedEvent E)
    {
        if (E.Object == ParentObject)
        {
            E.WantToRemove(this);
        }
        return base.HandleEvent(E);
    }

    public override bool HandleEvent(ReplaceInContextEvent E)
    {
        ParentObject.RemovePart(this);
        E.Replacement.AddPart(this);
        return base.HandleEvent(E);
    }

    public override bool HandleEvent(AfterDieEvent E)
    {
        if (E.Dying == ParentObject)
        {
            Trigger();
            if (GameState != null)
            {
                The.Game.SetBooleanGameState(GameState, true);
            }
        }
        return base.HandleEvent(E);
    }
    public virtual void Trigger()
    {
        // if (!The.Game.TryGetQuest(this.Quest, out var Quest))
        // {
        //     Quest = The.Game.StartQuest(this.Quest);
        // }
        The.Game.FinishQuestStep(Quest, Step);
        The.Game.FinishQuest(Quest);
        if (Clean)
        {
            ParentObject.RemovePart(this);
        }
    }
}

}