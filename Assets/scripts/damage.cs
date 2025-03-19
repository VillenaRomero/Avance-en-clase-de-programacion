using UnityEngine;

public interface IDamage { 
     public void takedamage();
}
public interface Iheal {
    public void HealDamage();
}

public class damage : MonoBehaviour,IDamage,Iheal
{
    public void TakeDamage() { 
    
    }
    public void healDamage() { 
    
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
