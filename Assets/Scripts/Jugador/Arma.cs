using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : PoolManager
{
    //Cadencia
    public float cadenciaBalas = 0.25f;

    //Velocidad
    [SerializeField] public static float velocidadBalas = 20f;

    //Dano
    [SerializeField] public static float danoBalas = 15f;

    //Disparo
    [SerializeField] private float ultimoDisparo;

    [SerializeField] Transform jugador;
   
    private void Awake()
    {
        ultimoDisparo = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        //Disparar
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Space)) /////////////////////////////////////////////////////////////////
        {
            if (ultimoDisparo < Time.time)
            {
                ultimoDisparo = Time.time + cadenciaBalas;
                PedirObjeto();
            }
        }
    }
    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        Objeto.transform.position = transform.position;
        Objeto.transform.rotation = jugador.rotation;
        Objeto.SetActive(true);
        Objeto.GetComponent<Bala>().DispararBala(jugador);

        return Objeto;
    }
    
}
