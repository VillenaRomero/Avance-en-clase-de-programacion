using UnityEngine;

public abstract class Habilidad : MonoBehaviour
{
    private string spellName;
    private int manacost;
    private float cooldown;
    private int level;
    private string spellDescription;

    public virtual void Cast() {
        print("cast basico");
    }

    public virtual void Cancell() { 
    
    }
}
public class Fireball : Habilidad {
    public override void Cast()
    {
        print("fireball");
    }



    private void Start()
    {
        Cast();
    }
}
public class thunder : Habilidad
{
    public override void Cast()
    {
        base.Cast();
        print("thunder");
    }



    private void Start()
    {
        Cast();
    }
}