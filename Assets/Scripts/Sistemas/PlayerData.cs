
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public float[] puntajeAcumulado;
   
    public PlayerData(AdminPuntaje adminPuntaje) 
    {
       puntajeAcumulado = adminPuntaje.puntosAcumuados;
    }
}
