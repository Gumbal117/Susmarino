using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : PoolManager
{
    
    
    public List <Transform> enemys;
    [SerializeField] private GameObject enemigos;
    [SerializeField] public float tiempoEnemigos;
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
            tiempoSigienteEnemigo = 0;
            
            if (tiempoEnemigos > 1)
            {
                tiempoEnemigos -= 0.5f;
            }

        }
       
    }
    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        
        Vector2 pos= new Vector2 (Random.Range(-50, 50), Random.Range(-50, 50));
        Objeto.transform.position = pos;
        Objeto.transform.rotation = transform.rotation;
        Objeto.SetActive(true);
        enemys.Add(Objeto.transform);

        return Objeto;
    }
}
