using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiarescena : MonoBehaviour
{

    public bool pasarNivel;
    public int indiceNivel;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Vidajugador>() != null)
        {
            CambiarNivel(indiceNivel);
        }
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
