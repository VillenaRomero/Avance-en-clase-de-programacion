using UnityEngine;

public class warrior : Personaje
{
    public override void Attack(){
        print( Name + "warrior attack");
    }
    public override void Defensa(){
        print("warrior defensa");
    }
    public override void Flee()
    {
        print("warrior escapa");
    }
}
