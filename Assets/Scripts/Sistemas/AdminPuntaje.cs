using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AdminPuntaje : MonoBehaviour
{ 
    [SerializeField] public float[] puntosAcumuados = new float[5];
    
    public static AdminPuntaje instance;
    private void Awake()
    {
        if (AdminPuntaje.instance == null)
        {
            AdminPuntaje.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    private void Update()
    {
    }
    public void AñadirUnNuevoPuntaje(float puntos)
    {
        PlayerData playerData = SaveManager.LoadPlayerScore();
        for (int i = 0; i < puntosAcumuados.Length; i++)
        {
            if (puntosAcumuados[i]<puntos)
            {
                puntosAcumuados[i] = puntos;
            }
        }
        playerData.puntajeAcumulado = puntosAcumuados;
        SaveManager.SavePlayerScore(this);
    }
    public void GuardarPuntaje()
    {
        SaveManager.SavePlayerScore(this);
    }
    public void CargarPuntaje()
    {
        PlayerData playerData = SaveManager.LoadPlayerScore();

        puntosAcumuados = playerData.puntajeAcumulado;
        Debug.Log("CargaPuntajeExitosa");
        SaveManager.SavePlayerScore(this);
    }
    public void OrdenarPuntajes()
    {
        Array.Sort(puntosAcumuados);
    }
    public void ResetPredeterminado()
    {
        for (int i = 0; i < puntosAcumuados.Length; i++)
        {
            puntosAcumuados[i] = 0f;

        }
        SaveManager.SavePlayerScore(this);
        Debug.Log("Reset exitoso");
    }
}
