using UnityEngine;

public class Déplacement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    Vector2 direction = new Vector2(1, 0);
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
    }
}
