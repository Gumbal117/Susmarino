using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.VFX;

public class Bala : MonoBehaviour
{
    private Rigidbody2D rigidbody2DBala;
    private float velocidad;
    private float dañoBala=1;
    private void Awake()
    {
        rigidbody2DBala=GetComponent<Rigidbody2D>();    
        velocidad = Arma.velocidadBalas;
        dañoBala = Arma.danoBalas;
    }
    public void DispararBala(Transform dir)
    {
        transform.rotation = dir.rotation;
        rigidbody2DBala.AddForce( transform.up * velocidad, ForceMode2D.Impulse);
    }
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Destructible>() != null)
        {

            gameObject.SetActive(false);
            collision.GetComponent<Destructible>().QuitarVida(dañoBala);

        }
       
    }

    */
}
