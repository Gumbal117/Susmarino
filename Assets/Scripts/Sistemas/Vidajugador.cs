using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidajugador : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaM�xima=3;
    [SerializeField] private BarraDeVida barradevida;
    public bool pasarNivel;
    public int indiceNivel;
    private void Start()
    {
        vida = vidaM�xima;
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
    public void TomarDa�o (float da�o)
        {
        vida -= da�o;
        barradevida.CambiarVidaActual(vida);
        
        
        }
    public void RecibirVida(float da�o)
    {
        vida += da�o;
        barradevida.CambiarVidaActual(vida);
        if (vida > vidaM�xima)
        {
            vida = vidaM�xima;
        }
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
   
}
