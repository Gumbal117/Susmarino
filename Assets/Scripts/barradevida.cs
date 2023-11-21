using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barradevida : MonoBehaviour
{
    private Slider slider;
    private void Start()
    {
        slider=GetComponent <Slider>();
    }
    public void CambiarVidaM�xima (float vidaM�xima)
    {
        slider.maxValue = vidaM�xima;
    }
    public void CambiarVidaActual (float cantidadvida)
    {
        slider.value = cantidadvida;
    } 
    public void InicializarBarraDeVida(float cantidaddvida)
    {
        CambiarVidaM�xima(cantidaddvida);
        CambiarVidaActual(cantidaddvida);
    }
}
