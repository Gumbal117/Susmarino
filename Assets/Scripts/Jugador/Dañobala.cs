using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañobala : MonoBehaviour
{

    public float daño = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Vidaenemigos>() != null)
        {
            other.gameObject.GetComponent<Vidaenemigos>().TomarDaño(daño);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<Vidaenemigos>() != null)
        {
            other.gameObject.GetComponent<Vidaenemigos>().TomarDaño(daño);
            gameObject.SetActive(false);
        }
    }
}
