using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AdminPuntaje : MonoBehaviour
{ 
    [SerializeField] public float[] puntosAcumuados;
    
    public static AdminPuntaje instance;
    private void Awake()
    {
        if (AdminPuntaje.instance == null)
        {
            AdminPuntaje.instance = this;
            //SaveManager.SavePlayerScore(this);

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void GuardarAcumulado(float puntos, int i)
    {
        PlayerData playerData = SaveManager.LoadPlayerScore();

        puntosAcumuados[i] += puntos;
        playerData.puntajeAcumulado = puntosAcumuados;
        SaveManager.SavePlayerScore(this);

    } 
    public void AcumuladoResta(float puntos, int i)
    {
        PlayerData playerData = SaveManager.LoadPlayerScore();


        puntosAcumuados[i] -= puntos;
        playerData.puntajeAcumulado = puntosAcumuados;
        Debug.Log("CobroExitoso");
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
