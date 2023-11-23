using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public GameObject jugador;
    public float speed = 2f;
    public float daño = 2;
    public float rotSpeed = 0.5f;
    private bool isFollowing = true;
    void Update()
    {
        if (isFollowing)
        {

             jugador = GameObject.FindFirstObjectByType<vidajugador>().gameObject;


            if (jugador == null)
            {
                return;
            }
            

            transform.position = Vector3.MoveTowards(transform.position, jugador.transform.position, speed * Time.deltaTime);
            Vector3 mirarA = jugador.transform.position - transform.position;
            transform.up = mirarA;

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<vidajugador>() != null)
        {
            other.gameObject.GetComponent<vidajugador>().TomarDaño(daño);
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
     {
         if (other.gameObject.GetComponent<vidajugador>() != null)
         {
             other.gameObject.GetComponent<vidajugador>().TomarDaño(daño);
         }
     }

    
}