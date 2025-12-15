using UnityEngine;

public class Skeleton : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 50;
    }

    
    void Update()
    {
        Debug.Log("Skeleton HP: " + HP);
        myMove();

        
    }
    
    

    
}
