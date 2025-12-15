using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class Spawnerennemy : MonoBehaviour

    //Je créer ma classe parent ennemy avec ses stats ainsi que les classes enfants qui héritent des stats
{
    public List<string> EnnemyList = new List<string> { "Gobelin", "Squelette" };
    public class Ennemy
    {
        public int vie = 85;
        public virtual void Attaquer() { }
    }
    public class Gobelin : Ennemy
    {
        public override void Attaquer() { }
    }

    public class Squelette: Ennemy
    {         
        public override void Attaquer() { }
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
