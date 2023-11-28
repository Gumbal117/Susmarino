using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidaenemigos : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaMáxima = 3;
    // Start is called before the first frame update
    void Start()
    {
        vida = vidaMáxima;
    }

    // Update is called once per frame
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
