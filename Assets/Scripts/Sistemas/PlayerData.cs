
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public float[] puntajeAcumulado = new float[5];
   
    public PlayerData(AdminPuntaje adminPuntaje) 
    {
       puntajeAcumulado = adminPuntaje.puntosAcumuados;
    }
}
