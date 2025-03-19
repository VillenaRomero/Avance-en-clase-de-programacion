using UnityEngine;

public class GameManger : MonoBehaviour
{
    private warrior warrior1 = new warrior();
    private warrior warrior2 = new warrior();
    private warrior warrior3 = new warrior();

    private Wizard wizard1 = new Wizard();

    private goblin goblin = new goblin();

    private Fireball fireball = new Fireball();
    private thunder thunder = new thunder();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       /* warrior1.Set("palomino", 10, 223, 34, 3.4f, 6.7f, 23, 45);
        warrior1.Attack();
        warrior2.Set("Kaleb", 41, 20, 78 , 6.2f, 7.1f, 10, 48);
        warrior2.Attack();
        warrior3.Set("Kaleb", 23, 23, 34, 4.5f, 6.7f, 87, 34);
        warrior3.Attack();

        wizard1.Set("jesus",23,89,23,3.4f,5.6f,12,78);*/

        fireball.Cast();
        thunder.Cast();


       // goblin.UpdatePosition(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
