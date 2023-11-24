using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidajugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaMáxima=3;
    [SerializeField] private BarraDeVida barradevida;
    public bool pasarNivel;
    public int indiceNivel;
    private void Start()
    {
        vida = vidaMáxima;
        barradevida.InicializarBarraDeVida(vida);
    }
    private void Update()
    {
        barradevida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
           
            CambiarNivel(indiceNivel);
        }
    }
    public void TomarDaño (float daño)
        {
        vida -= daño;
        barradevida.CambiarVidaActual(vida);
        
        
        }
    public void RecibirVida(float daño)
    {
        vida += daño;
        barradevida.CambiarVidaActual(vida);
        if (vida > vidaMáxima)
        {
            vida = vidaMáxima;
        }
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
   
}
