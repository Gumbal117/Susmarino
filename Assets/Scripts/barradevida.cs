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
    public void CambiarVidaMáxima (float vidaMáxima)
    {
        slider.maxValue = vidaMáxima;
    }
    public void CambiarVidaActual (float cantidadvida)
    {
        slider.value = cantidadvida;
    } 
    public void InicializarBarraDeVida(float cantidaddvida)
    {
        CambiarVidaMáxima(cantidaddvida);
        CambiarVidaActual(cantidaddvida);
    }
}
