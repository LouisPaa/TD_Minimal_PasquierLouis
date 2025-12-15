using UnityEngine;

public class StatsPersonnage : MonoBehaviour

    //Je définie les stats du personnage jouable
{
    int damg = 50;
    int hp = 100;
    int special = 80;

    // Je définie ce quin se passe quand le personnage rentre en collisiion avec un ennemi

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Skeleton"|| collision.gameObject.name == "Gobelin")
        {
            Debug.Log("RENTRER EN COLLISION");
            collision.gameObject.GetComponent<Enemy>().TakeDammage(1000);
        }  
    }

    private void Update()
    {
        
    }
}
