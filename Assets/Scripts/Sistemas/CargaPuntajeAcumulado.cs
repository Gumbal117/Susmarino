using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CargaPuntajeAcumulado : MonoBehaviour
{
    public float[] puntosAcumuadosEnMEnu= new float[5];
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Awake()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        ChecarAdminPuntaje();
    }
    private void OnEnable()
    {
        ChecarAdminPuntaje();
    }
    private void Update()
    {
        
        
        m_TextMeshProUGUI.text = puntosAcumuadosEnMEnu[4].ToString("0")+"\n"
            +puntosAcumuadosEnMEnu[3].ToString("0") + "\n"
             + puntosAcumuadosEnMEnu[2].ToString("0") + "\n"
              + puntosAcumuadosEnMEnu[1].ToString("0") + "\n"
               + puntosAcumuadosEnMEnu[0].ToString("0") + "\n";

        
    }
    public void ChecarAdminPuntaje()
    {
        if (AdminPuntaje.instance != null)
        {
            puntosAcumuadosEnMEnu = AdminPuntaje.instance.puntosAcumuados;
            AdminPuntaje.instance.CargarPuntaje();

        }
    }
    
}
