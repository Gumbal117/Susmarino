using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidajugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaMáxima=3;
    [SerializeField] private BarraDeVida barradevida;
    private void Start()
    {
        vida = vidaMáxima;
        barradevida.InicializarBarraDeVida(vida);
    }
    private void Update()
    {
        barradevida.CambiarVidaActual(vida);
    }
    public void TomarDaño (float daño)
        {
        vida -= daño;
        barradevida.CambiarVidaActual(vida);
        if (vida==0)
        {
            gameObject.SetActive(false);
        }
        
        }
    public void RecibirVida(float daño)
    {
        vida += daño;
        barradevida.CambiarVidaActual(vida);
        if (vida > vidaMáxima)
        {
            vida = vidaMáxima;
        }
    }
   
}
