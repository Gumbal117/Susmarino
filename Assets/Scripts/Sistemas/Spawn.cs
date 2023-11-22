using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : PoolManager
{
    
    
    public List <Transform> enemys;
    [SerializeField] private GameObject enemigos;
    [SerializeField] public float tiempoEnemigos;
    [SerializeField] public float tiempoEnemigosMax;
    [SerializeField] public float tiempoEnemigosMin;
    private float tiempoSigienteEnemigo;
    
   
    void Update()
    {
        JuegoInfinito();
    }
    public void JuegoInfinito()
    {
        tiempoSigienteEnemigo += Time.deltaTime;
        if (tiempoSigienteEnemigo >= tiempoEnemigos)
        {


            PedirObjeto();
            tiempoEnemigos = Random.Range(tiempoEnemigosMin, tiempoEnemigosMax);
            tiempoSigienteEnemigo = 0;
            
            if (tiempoEnemigosMin > 1)
            {
                tiempoEnemigosMin -= 0.5f;
                tiempoEnemigosMax -= 0.5f;
            }

        }
       
    }
    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        
        Vector2 pos= new Vector2 (Random.Range(-100, 100), Random.Range(-100, 100));
        Objeto.transform.position = pos;
        Objeto.transform.rotation = transform.rotation;
        Objeto.SetActive(true);
        enemys.Add(Objeto.transform);

        return Objeto;
    }
}
