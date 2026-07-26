using System;
using XRL.World.Effects;
using XRL.Rules;

namespace XRL.World.Parts {

[Serializable]
public class Ursa_LovesickOnHit : IPart
{
    public int Duration = 60;

    public int DurationRandomness = 60;

    public override bool AllowStaticRegistration()
    {
        return true;
    }

    public override void Register(GameObject Object, IEventRegistrar Registrar)
    {
        Registrar.Register("ProjectileHit");
        Registrar.Register("WeaponHit");
        Registrar.Register("WeaponThrowHit");
        base.Register(Object, Registrar);
    }

    public override bool FireEvent(Event E)
    {
        if (E.ID == "WeaponHit" || E.ID == "ProjectileHit" || E.ID == "WeaponThrownHit")
        {
            GameObject gameObjectParameter = E.GetGameObjectParameter("Attacker");
            if (gameObjectParameter != null && !gameObjectParameter.HasEffect<Lovesick>())
            {
                 E.GetGameObjectParameter("Defender").ApplyEffect(new Lovesick(Stat.Random(Duration, Duration+DurationRandomness), gameObjectParameter));
            }
        }
        return base.FireEvent(E);
    }
}

}