using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : PoolManager
{
   
    [SerializeField] private Transform jugador;
    [SerializeField] private List<Transform> enemigos;
    [SerializeField] private Transform radar;
    [SerializeField] private GameObject enemyIcon;
    [SerializeField] private SpawnManager spawn;

  

    [SerializeField] private float maxDistance;
    [SerializeField] private float radarScale;

   
    void Start()
    {
        enemigos = new List<Transform>();
        enemigos.Clear();
    }
    void Update()
    {
        enemigos = spawn.totalEnemys;
        if (enemigos.Count!=objetosCreados.Count)
        {
            
            CreateEnemyIcons();

        }
        else
        {

            UpdateRadarPos();
            
        }
    }
    
    public void CreateEnemyIcons()
    {
        
        for (int i = 0; i < enemigos.Count; i++)
        {
            if (i < objetosCreados.Count)
            {

                objetosCreados[i].gameObject.SetActive(false);
            }

            PedirObjetoHijo(radar);

        }
        Debug.Log("Se crearon los iconos") ;
    }
    void UpdateRadarPos()
    {
        for (int i = 0; i < enemigos.Count; i++)
        {
            Vector2 enemyPos = enemigos[i].position - jugador.position;
            Vector2 radarEnemyPos = RadarPosition(radarScale * enemyPos / maxDistance);
            objetosCreados[i].transform.localPosition = radarEnemyPos;
            if (radarEnemyPos.magnitude > radarScale || !enemigos[i].gameObject.activeSelf)
            {
                objetosCreados[i].gameObject.SetActive(false);
            }
            else
            {
                objetosCreados[i].gameObject.SetActive(true);
            }
        }
        Debug.Log("Se esta siguiendo al enemigo");
    }
    Vector2 RadarPosition(Vector2 position)
    {
        float x = Vector2.Dot(radar.right, position);
        float y = Vector2.Dot(radar.up, position);
        float z = Vector2.Dot(radar.forward, position);

        return new Vector2(x,y);
    }
    public override GameObject PedirObjetoHijo(Transform origen)
    {
        GameObject Objeto = base.PedirObjetoHijo(origen);
      
        Objeto.SetActive(true);
        return Objeto;
    }
}
