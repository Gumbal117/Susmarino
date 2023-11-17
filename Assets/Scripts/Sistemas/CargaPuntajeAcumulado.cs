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
        ChecarAdminPuntaje();
        for (int i = 0; i < puntosAcumuadosEnMEnu.Length; i++)
        {
            m_TextMeshProUGUI.text = puntosAcumuadosEnMEnu[i].ToString("0");
        }
    }
    private void ChecarAdminPuntaje()
    {
        if (AdminPuntaje.instance != null)
        {
            puntosAcumuadosEnMEnu = AdminPuntaje.instance.puntosAcumuados;
            AdminPuntaje.instance.CargarPuntaje();

        }
    }
    
}
