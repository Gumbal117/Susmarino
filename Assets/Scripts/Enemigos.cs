using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public string objectTag;
    public float speed = 2f;
    public float rotSpeed = 0.5f;
    private bool isFollowing = true;
    void Update()
    {
        if (isFollowing)
        {

            GameObject targetObject = GameObject.FindWithTag("Player");


            if (targetObject == null)
            {
                return;
            }


            transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, speed * Time.deltaTime);


            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetObject.transform.position - transform.position), rotSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // other.gameObject.GetComponent<vidajugador>().TomarDa�o(1);
            gameObject.SetActive(false);
        }
    }
    /* private void OnCollisionEnter(Collision other)
     {
         if (other.gameObject.CompareTag("player"))
         {
             other.gameObject.GetComponent<vidajugador>().TomarDa�o(1);
         }
     }*/

    
}