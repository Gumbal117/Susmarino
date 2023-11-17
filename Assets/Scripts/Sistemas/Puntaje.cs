using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public float puntos=0;
    public bool score = true;
    private TextMeshProUGUI m_TextMeshProUGUI;

    private void OnEnable()
    {
        puntos =0;
        score = true;

    }
    private void Start()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
        score = true;
    }
private void Update()
    {
        
        if (score) 
        {
            puntos += Time.deltaTime;
            m_TextMeshProUGUI.text = puntos.ToString("0");
        }
        else 
        {
            
        }
    }
    
    public void SumarPuntos(float puntosdeentrada) 
    {
        puntos += puntosdeentrada;
    }
}
