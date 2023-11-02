using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovSubmarino : MonoBehaviour
{
    
    [SerializeField] private float gira;
    [SerializeField] private float velocidadDeGiro;
   

    // Update is called once per frame
    void Update()
    {

        gira = Input.GetAxis("Horizontal");
        Mathf.Clamp(velocidadDeGiro, -127, 127);
        velocidadDeGiro = velocidadDeGiro * gira * 127;
         
        transform.Rotate(0,0,velocidadDeGiro,Space.World);
    }
}
