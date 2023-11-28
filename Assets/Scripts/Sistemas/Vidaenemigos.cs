using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidaenemigos : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaMáxima = 3;
    
    

    private void OnEnable()
    {
        vida = vidaMáxima;
    }
    void Update()
    {
        if (vida <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void TomarDaño(float daño)
    {
        vida -= daño;


    }
}
