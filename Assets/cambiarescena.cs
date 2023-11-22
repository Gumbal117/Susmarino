using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarescena : MonoBehaviour
{

    public bool pasarNivel;
    public int indiceNivel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CambiarNivel(indiceNivel);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void CambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
