using UnityEngine;
using Unity.Collections;

 public abstract class Personaje : MonoBehaviour
{
    private string name;
   
    private int life;
    private int mana;
    
    private float strg;
    private float spd;
    private float inteligencia;

    private int defense;

    private int level;
    public string Name => name;

    public string GetName()
    {
        return name;
    }

    public void Set(string name, int life, int mana, float strg, float spd, float inteligencia ,int defense, int level) { 
    this.name=name;
    this.life=life;
    this.mana=mana;
    this.strg=strg;
    this.spd=spd;
    this.inteligencia=inteligencia;
    this.defense=defense;
        this.level=level;
    }
    public abstract void Attack();
    public abstract void Defensa();
    public abstract void Flee();
}
public class Wizard : Personaje
{
    public override void Attack()
    {
        print(GetName() + "Mago Atacko");
    }
    public override void Defensa()
    {
        print("Mago defendio");

    }
    public override void Flee()
    {
        print("Mago escapo");

    }
}
