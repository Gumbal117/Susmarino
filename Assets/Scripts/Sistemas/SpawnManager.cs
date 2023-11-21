using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Spawn negachin;
    public Spawn calamardo;
    public Spawn doncangrejo;

    public List<Transform> totalEnemys;


    private void Awake()
    {
        totalEnemys = new List<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (totalEnemys.Count !<= negachin.enemys.Count+ calamardo.enemys.Count+ doncangrejo.enemys.Count) 
        {
            totalEnemys.Clear();
            totalEnemys.AddRange(calamardo.enemys);
            totalEnemys.AddRange(negachin.enemys);
            totalEnemys.AddRange(doncangrejo.enemys);
        }
        
        
    }
}
