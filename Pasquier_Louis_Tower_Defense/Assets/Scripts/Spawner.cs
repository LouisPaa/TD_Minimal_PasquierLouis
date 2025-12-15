using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Je créer un prefab de skeleton et de gobelin
    public GameObject[] monsters = new GameObject[2];

    // je définie le nombre de monstre maximal qui apparait 
    public int nbMonsterSpawn = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        StartCoroutine(spawnMonster());
    }

    // Je fait apparaitre les monstres de façon aléatoire 
    IEnumerator spawnMonster()
    {
        for (int i = 0; i < nbMonsterSpawn; i++)
        {
            for (int vague = 1; vague <= 5; vague++)
            {
                yield return new WaitForSeconds(0.5f);
                GameObject monster;

                if (Random.Range(0f, 1f) > 0.5f)
                {
                    monster = Instantiate(monsters[0], transform.position, Quaternion.identity);
                    monster.name = "Gobelin";
                }
                else
                {
                    monster = Instantiate(monsters[1], transform.position, Quaternion.identity);
                    monster.name = "Skeleton";
                }

                yield return new WaitForSeconds(2);
            }
        }

    }
}
