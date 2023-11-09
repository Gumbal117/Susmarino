using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaBombas : PoolManager
{
    //Cadencia
    public float cadenciaBombas;
    public float bombasCooldown;
    //Velocidad
   
    [SerializeField]public static float velocidadBombas = 5f;
    //Dano

    [SerializeField] public static float danoBombas = 20f;
    //Disparo

    [SerializeField] private float ultimoDisparoBomba;


    [SerializeField] Transform jugador;
   
    private void Awake()
    {
        ultimoDisparoBomba = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        //Disparar
      
        if (Input.GetKey(KeyCode.Q))///////////////////////////////////////////////////////////////////
        {
            if (ultimoDisparoBomba < Time.time)
            {
                ultimoDisparoBomba = Time.time + cadenciaBombas;
                bombasCooldown = 0;
                PedirObjeto();
            }
        }

        bombasCooldown += Time.deltaTime;
        bombasCooldown = Mathf.Clamp(bombasCooldown, 0, cadenciaBombas);
    }
    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        Objeto.transform.position = transform.position;
        Objeto.transform.rotation = jugador.rotation;
        Objeto.SetActive(true);
        Objeto.GetComponent<Bomba>().DispararBomba(jugador);

        return Objeto;
    }

}
