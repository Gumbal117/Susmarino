using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : PoolManager
{
    [SerializeField] private Transform jugador;
    [SerializeField] private Transform[] enemigos;
    [SerializeField] private Transform radar;
    [SerializeField] private GameObject enemyIcon;
    [SerializeField] private Spawn spawn;

    [SerializeField] private List<Transform> enemyIcons;

    [SerializeField] private float maxDistance;
    [SerializeField] private float radarScale;

    void Start()
    {
        enemyIcons = new List<Transform>();
        CreateEnemyIcons();
    }
    void Update()
    {
        for (int i = 0; i < spawn.numEnemigos; i++)
        {

        }
        UpdateRadarPos();
    }
    public void AgregarEnemigo(GameObject enemigoAAgragar)
    {
        enemyIcons.Add(enemigoAAgragar.transform);
    }
    void CreateEnemyIcons()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            PedirObjetoHijo(radar);
        }
        
        for (int i = 0; i < objetosCreados.Count; i++)
        {
            enemyIcons.Add(objetosCreados[i].transform);
        }
    }
    void UpdateRadarPos()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            Vector2 enemyPos = enemigos[i].position - jugador.position;
            Vector2 radarEnemyPos = RadarPosition(radarScale * enemyPos / maxDistance);
            enemyIcons[i].localPosition = radarEnemyPos;
            if (radarEnemyPos.magnitude> radarScale)
            {
                enemyIcons[i].gameObject.SetActive(false);
            }
            else
            {
                enemyIcons[i].gameObject.SetActive(true);
            }
        }
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
