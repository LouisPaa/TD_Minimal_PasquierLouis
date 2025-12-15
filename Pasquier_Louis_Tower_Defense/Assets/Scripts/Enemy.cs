using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP = 100;
    void Start()
    {

    }

    // Update is called once per frame
    Vector2 direction = new Vector2(-2, 0);
    // protected empêche un autre objet  étranger à Enemy qui a la même fonction d'interférer
    protected void myMove()
    {
        transform.Translate(direction * Time.deltaTime);
    }

    // Je définie ce qui arrive si l'ennemi perd de la vie
    public void TakeDammage(int damage)
    {
        HP -= damage;
        if (HP <= 0)
        {
            Destroy(gameObject);
        }

    }  

    // Je définis la destruction de l'ennemi en appuyant sur A
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {

            Destroy(gameObject);
                Debug.Log("L'ennemi est détruit");
            }
        }
       
    

}
