using UnityEngine;

public struct position {
    int x;
    int y;
    int z;
    public Vector3 GetPosition() {
        return new Vector3(x,y,z);
    }
    public void set(int x, int y, int z) {
        x = x;
        y = y;
        z = z;
    }
}
public class goblin : MonoBehaviour
{
    int hp;
    private position Position = new position();

    public void UpdatePosition(int x, int y, int z) {
        Position.set( x , y , z);
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
