using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class MovArduinoSubmarino : MonoBehaviour
{
    public GameObject botn_1;
    public GameObject botn_2;
    public GameObject botn_3;
    //public GameObject botn_4;
    public GameObject Joystick;
    public float RotY = 90f;


    public float PosIni = 0.5f;

    SerialPort serialPort = new SerialPort("COM4", 9600);


    public float smooth = 20.0F;


   
    private float vGiro;
    private float vMov;

    [SerializeField] private float velocidadDeGiro;
    [SerializeField] private float velocidadDeMov;

    // Use this for initialization
    void Start()
    {

        serialPort.Open();
        serialPort.ReadTimeout = 1;
    }

    void Update()
    {

        if (serialPort.IsOpen)
        {
            try
            {

                string value = serialPort.ReadLine();
                print(value);
                string[] vec6 = value.Split(',');


                if ((Convert.ToInt32(vec6[0])) == 1)
                {
                    botn_1.transform.localPosition = new Vector2(botn_1.transform.localPosition.x, 0f);

                }
                else { botn_1.transform.localPosition = new Vector2(botn_1.transform.localPosition.x, PosIni); }

                if ((Convert.ToInt32(vec6[1])) == 1)
                {
                    botn_2.transform.localPosition = new Vector2(botn_2.transform.localPosition.x, 0f);

                }
                else { botn_2.transform.localPosition = new Vector2(botn_2.transform.localPosition.x, PosIni); }

                if ((Convert.ToInt32(vec6[2])) == 1)
                {
                    botn_3.transform.localPosition = new Vector2(botn_3.transform.localPosition.x, 0f);
                }
                else { botn_3.transform.localPosition = new Vector2(botn_3.transform.localPosition.x, PosIni); }
                /*
                if ((Convert.ToInt32(vec6[3])) == 1)
                {
                    botn_4.transform.localRotation = Quaternion.Euler(0, RotY, 0);

                }
                else { botn_4.transform.localRotation = Quaternion.Euler(0, 0, 0); }
                */
                vGiro = Convert.ToInt32(vec6[4]) * Time.deltaTime * velocidadDeGiro;
                vMov = Convert.ToInt32(vec6[5]) * Time.deltaTime * velocidadDeMov;

                transform.Rotate(0, 0, vGiro, Space.World);
                Vector2 moviento = vMov * Vector2.up;
                transform.Translate(moviento);

                transform.position = new Vector2(Mathf.Clamp(transform.position.x, -50, 50),
                Mathf.Clamp(transform.position.y, -50, 50));
            }

            catch
            {


            }


        }


    }
   
}
