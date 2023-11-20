using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public float puntos=0;
    private TextMeshProUGUI m_TextMeshProUGUI;
    private void OnEnable()
    {
        puntos = 0;
    }
    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
private void Update()
    {
        m_TextMeshProUGUI.text = puntos.ToString("0");
    }
    public void SumarPuntos(float puntosdeentrada) 
    {
        puntos += puntosdeentrada;
    }
    public void HighScore()
    {
        AdminPuntaje.instance.AñadirUnNuevoPuntaje(puntos);
    }
}
