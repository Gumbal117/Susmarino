using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CargaPuntajeAcumulado : MonoBehaviour
{
    public float[] puntosAcumuadosEnMEnu;

   

    private TextMeshProUGUI m_TextMeshProUGUI;

    private void Awake()
    {
        

        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();

        if (AdminPuntaje.instance != null)
        {
            puntosAcumuadosEnMEnu = AdminPuntaje.instance.puntosAcumuados;
            AdminPuntaje.instance.CargarPuntaje();
        }



    }
    private void OnEnable()
    {
        if (AdminPuntaje.instance != null)
        {
            puntosAcumuadosEnMEnu = AdminPuntaje.instance.puntosAcumuados;
            AdminPuntaje.instance.CargarPuntaje();

        }

    }
    private void Update()
    {
        if (AdminPuntaje.instance != null)
        {
            puntosAcumuadosEnMEnu = AdminPuntaje.instance.puntosAcumuados;

        }
        for (int i = 0; i < puntosAcumuadosEnMEnu.Length; i++)
        {
            m_TextMeshProUGUI.text = puntosAcumuadosEnMEnu[i].ToString("0");

        }

    }

    
}
