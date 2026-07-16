using System;
using XRL.World.Effects;

namespace XRL.World.Parts {

[Serializable]
public class Ursa_ShakenOnHit : IPart
{
    public int Chance = 100;

    public string Strength = "35";

    public string Duration = "6-9";

    public override bool AllowStaticRegistration()
    {
        return true;
    }

    public override void Register(GameObject Object, IEventRegistrar Registrar)
    {
        if (Object.IsCreature)
        {
            Registrar.Register("AttackerHit");
            return;
        }
        if (Object.IsProjectile)
        {
            Registrar.Register("ProjectileHit");
            return;
        }
        Registrar.Register("WeaponHit");
        Registrar.Register("WeaponThrowHit");
    }

    public override bool FireEvent(Event E)
    {
        if (E.ID.EndsWith("Hit"))
        {
            GameObject gameObjectParameter = E.GetGameObjectParameter("Attacker");
            GameObject Object = E.GetGameObjectParameter("Defender");
            GameObject gameObjectParameter2 = E.GetGameObjectParameter("Projectile");
            if (GameObject.Validate(ref Object))
            {
                GameObject parentObject = ParentObject;
                GameObject subject = Object;
                GameObject projectile = gameObjectParameter2;
                if (GetSpecialEffectChanceEvent.GetFor(gameObjectParameter, parentObject, "Part Ursa_ShakenOnHit Activation", Chance, subject, projectile).in100())
                {
                    int num = Strength.RollCached();
                    if (!Object.MakeSave("Toughness", num, null, null, "Shaken", IgnoreNaturals: false, IgnoreNatural1: false, IgnoreNatural20: false, IgnoreGodmode: false, ParentObject))
                    {
                        Object.ApplyEffect(new Shaken(Duration.RollCached(), 8));
                    }
                }
            }
        }
        return base.FireEvent(E);
    }
}

}