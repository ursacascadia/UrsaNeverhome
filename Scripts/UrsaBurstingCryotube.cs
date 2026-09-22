using System;
using System.Collections.Generic;
using XRL;
using XRL.Core;

namespace XRL.World.Parts {

[Serializable]
public class UrsaBurstingCryotube : IPart
{
    public override bool WantEvent(int ID, int cascade)
    {
        return base.WantEvent(ID, cascade)
            || ID == BeginTakeActionEvent.ID;
    }
    
    public override bool HandleEvent(BeginTakeActionEvent E)
    {
        List<Cell> localAdjacentCells = ParentObject.Physics.CurrentCell.GetLocalAdjacentCells();
        if (localAdjacentCells != null)
        {
            foreach (Cell cell in localAdjacentCells)
            {
                if (!cell.HasObjectWithPart("Brain")) // if no brain skip cell
                {
                    continue;
                }
                foreach (GameObject obj in cell.GetObjectsWithPart("Brain"))
                {
                    if (obj.HasPart("Brain") && obj.GetPart<Brain>().IsAlliedTowards(The.Player)) // If the object is allied to the player, explode
                    {
                        ParentObject.Die();
                        break;
                    }
                }
            }
        }
        return base.HandleEvent(E);
    }

}

}