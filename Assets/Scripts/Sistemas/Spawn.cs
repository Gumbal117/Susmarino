using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : PoolManager
{
    
    
    public List <Transform> enemys;
    [SerializeField] private GameObject enemigos;
    [SerializeField] public float tiempoEnemigos;
    [SerializeField] public int cantidadDeEnemigos;
    [SerializeField] public int cantidadDeEnemigosEnJuego;
    [SerializeField] public bool esInfinito;
    private float tiempoSigienteEnemigo;
    public Quaternion rotacion;
    private void Start()
    {
        

    }
    void Update()
    {
        if (esInfinito)
        {
            JuegoInfinito();
        }
        else
        {
            JuegoNormal();
        }

    }

    
    public void JuegoNormal()
    {
        tiempoSigienteEnemigo += Time.deltaTime;
        if (tiempoSigienteEnemigo >= tiempoEnemigos)
        {
            PedirObjeto();
            tiempoSigienteEnemigo = 0;
            cantidadDeEnemigosEnJuego++;
        }
        if (cantidadDeEnemigos == cantidadDeEnemigosEnJuego)
        {
            gameObject.SetActive(false);
        }
    }
    public void JuegoInfinito()
    {
        tiempoSigienteEnemigo += Time.deltaTime;
        if (tiempoSigienteEnemigo >= tiempoEnemigos)
        {
            PedirObjeto();
            tiempoSigienteEnemigo = 0;
            
            if (tiempoEnemigos > 1)
            {
                tiempoEnemigos -= 0.5f;
            }

        }
        if (cantidadDeEnemigos == cantidadDeEnemigosEnJuego)
        {
            gameObject.SetActive(false);
        }
    }
    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        Objeto.transform.position = transform.position;
        Objeto.transform.rotation = transform.rotation;
        Objeto.SetActive(true);
        enemys.Add(Objeto.transform);

        return Objeto;
    }
}
