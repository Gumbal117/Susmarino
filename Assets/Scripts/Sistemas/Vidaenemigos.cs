using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidaenemigos : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaM�xima = 3;
    
    

    private void OnEnable()
    {
        vida = vidaM�xima;
    }
    void Update()
    {
        if (vida <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void TomarDa�o(float da�o)
    {
        vida -= da�o;


    }
}
