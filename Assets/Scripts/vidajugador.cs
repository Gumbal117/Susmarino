using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidajugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaM�xima=3;
    [SerializeField] private BarraDeVida barradevida;
    private void Start()
    {
        vida = vidaM�xima;
        barradevida.InicializarBarraDeVida(vida);
    }
    private void Update()
    {
        barradevida.CambiarVidaActual(vida);
    }
    public void TomarDa�o (float da�o)
        {
        vida -= da�o;
        barradevida.CambiarVidaActual(vida);
        if (vida==0)
        {
            gameObject.SetActive(false);
        }
        
        }
    public void RecibirVida(float da�o)
    {
        vida += da�o;
        barradevida.CambiarVidaActual(vida);
        if (vida > vidaM�xima)
        {
            vida = vidaM�xima;
        }
    }
   
}
