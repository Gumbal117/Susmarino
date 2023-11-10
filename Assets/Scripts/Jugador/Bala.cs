using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.VFX;

public class Bala : MonoBehaviour
{
    private new Rigidbody2D rigidbody2D;
    [SerializeField] private float velocidad;
    [SerializeField] private float daño;
    private void Awake()
    {
        rigidbody2D=GetComponent<Rigidbody2D>();    
        
    }
    public void Disparar(Transform dir)
    {
        transform.rotation = dir.rotation;
        rigidbody2D.AddForce( transform.up * velocidad, ForceMode2D.Impulse);
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
