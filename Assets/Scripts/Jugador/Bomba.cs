using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    private Rigidbody2D rigidbody2DBomba;
    private float velocidad;
    private float dañoBomba = 1;
    private void Awake()
    {
        rigidbody2DBomba = GetComponent<Rigidbody2D>();
        velocidad = ArmaBombas.velocidadBombas;
        dañoBomba = ArmaBombas.danoBombas;
    }
    public void DispararBomba(Transform dir)
    {
        transform.rotation = dir.rotation;
        rigidbody2DBomba.AddForce(transform.up * velocidad, ForceMode2D.Impulse);
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
