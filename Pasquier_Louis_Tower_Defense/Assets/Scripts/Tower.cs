using UnityEngine;

public class Tower : MonoBehaviour
{
    int hp = 300;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Je définie ce qui arrive si la tour n'a plus de vie
    void DestroyGameObject()
    {
        if (hp <= 0)
            Destroy(gameObject);
    }
}
