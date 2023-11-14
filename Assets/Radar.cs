using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] private Transform jugador;
    [SerializeField] private Transform[] enemigos;

    [SerializeField] private float maxDistance;
    [SerializeField] private float radarScale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateEnemyIcons()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {

        }
    }
}
