using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovSubmarino : MonoBehaviour
{
    
     private float gira;
     private float mueve;
     private float vGiro;
     private float vMov;

    [SerializeField] private float velocidadDeGiro;
    [SerializeField] private float velocidadDeMov;
   

    // Update is called once per frame
    void Update()
    {
        gira = Input.GetAxis("Horizontal");//////////////////////////////////////////////
        mueve = Input.GetAxis("Vertical");//////////////////////////////////////////////
        
        vGiro =   gira * Time.deltaTime * velocidadDeGiro;
        vMov =   mueve * Time.deltaTime * velocidadDeMov;
         
        transform.Rotate(0,0,vGiro,Space.World);
        Vector2 moviento = vMov * Vector2.up;
        transform.Translate(moviento);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -50, 50),
        Mathf.Clamp(transform.position.y, -50, 50));
    }
}
