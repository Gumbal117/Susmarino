using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : PoolManager
{
    //Cadencia
    public float cadencia = 0.25f;
    //Disparo
    [SerializeField] private float ultimoDisparo;
    public float cooldown;
    [SerializeField] Transform jugador;
    [SerializeField] KeyCode kya;
    public enum EnumBotonDelArma { Balas, Bombas, Bengalas }

    [SerializeField] public EnumBotonDelArma botonDelArma;
    [SerializeField] private bool arduino;
    public MovArduinoSubmarino movArduino;


    private void Awake()
    {
        ultimoDisparo = Time.time;
        //movArduino = GetComponent<MovArduinoSubmarino>();

    }
    void Update()
    {
        //Disparar
        
        if (arduino)
        {
            switch (botonDelArma)
            {
                case EnumBotonDelArma.Balas:
                    if (movArduino.btn1==1) /////////////////////////////////////////////////////////////////
                    {
                        if (ultimoDisparo < Time.time)
                        {
                            ultimoDisparo = Time.time + cadencia;
                            PedirObjeto();
                            cooldown = 0;
                        }
                    }
                    break;
                case EnumBotonDelArma.Bombas:
                    if (movArduino.btn2 == 1) /////////////////////////////////////////////////////////////////
                    {
                        if (ultimoDisparo < Time.time)
                        {
                            ultimoDisparo = Time.time + cadencia;
                            PedirObjeto();
                            cooldown = 0;
                        }
                    }
                    break;
                case EnumBotonDelArma.Bengalas:
                    if (movArduino.btn3 == 1) /////////////////////////////////////////////////////////////////
                    {
                        if (ultimoDisparo < Time.time)
                        {
                            ultimoDisparo = Time.time + cadencia;
                            PedirObjeto();
                            cooldown = 0;
                        }
                    }
                    break;
                
            }

        }
        else
        {
            if (Input.GetKey(kya)) /////////////////////////////////////////////////////////////////
            {
                if (ultimoDisparo < Time.time)
                {
                    ultimoDisparo = Time.time + cadencia;
                    PedirObjeto();
                    cooldown = 0;
                }
            }
        }

        cooldown += Time.deltaTime;
        cooldown = Mathf.Clamp(cooldown, 0, cadencia);
    }
    public override GameObject PedirObjeto()
    {
        GameObject Objeto = base.PedirObjeto();
        Objeto.transform.position = transform.position;
        Objeto.transform.rotation = jugador.rotation;
        Objeto.SetActive(true);
        Objeto.GetComponent<Bala>().Disparar(jugador);

        return Objeto;
    }
    
}



