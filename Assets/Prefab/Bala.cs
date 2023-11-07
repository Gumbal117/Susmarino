using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Bala : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rigidbody2DBala;
    [SerializeField] public float velocidad;
    [SerializeField] public float dañoBala=1;
    private void Awake()
    {
        velocidad = Arma.velocidadBalas;
        dañoBala = Arma.danoBalas;
    }
    public void DispararBala()
    {
        rigidbody2DBala.AddForce(Vector2.up* velocidad, ForceMode2D.Impulse);
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
