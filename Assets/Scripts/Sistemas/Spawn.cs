using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Radar radar;
    public float numEnemigos;
    public GameObject[] enemys;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < numEnemigos; i++)
        {
            //radar.AgregarEnemigo(gameobjectdelenemigo);
        }
        
    }

}
