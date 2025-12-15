using UnityEngine;

public class Gobelin : Enemy //Le prefab hérite de la classe enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP=150;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Gobelin HP: " + HP);
        myMove();
    }
}
