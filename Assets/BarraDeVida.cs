using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Slider slider;
    private void Start()
    {
        slider = GetComponent<Slider>();
       
    }
    public void CambiarVidaM�xima(float vidaM�xima)
    {
        if (slider!= null)
        {
            slider.maxValue = vidaM�xima;
        }
        else
        {
            Debug.LogError("No hay Slider");
        }
        
    }
    public void CambiarVidaActual(float cantidadvida)
    {
       
        if (slider != null)
        {
            slider.value = cantidadvida;
        }
        else
        {
            Debug.LogError("No hay Slider");
        }
    }
    public void InicializarBarraDeVida(float cantidaddvida)
    {
        CambiarVidaM�xima(cantidaddvida);
        CambiarVidaActual(cantidaddvida);
    }
}
