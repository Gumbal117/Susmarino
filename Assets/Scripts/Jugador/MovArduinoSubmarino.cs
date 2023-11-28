using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class MovArduinoSubmarino : MonoBehaviour
{
    //public GameObject botn_1;
    //public GameObject botn_2;
    //public GameObject botn_3;
    //public GameObject botn_4;
    //public GameObject Joystick;


    SerialPort serialPort;

    public int potenc1;
    public int potenc2;
    public int btn1;
    public int btn2;
    public int btn3;

    // Use this for initialization
    void Start()
    {
        if (serialPort == null)
        {
            serialPort = new SerialPort(SerialPort.GetPortNames()[0], 9600);
        }
        else
        {
            return;
        }
        serialPort.Open();

    }

    void Update()
    {

        if (serialPort.IsOpen)
        {
            try
            {

                string value = serialPort.ReadLine();
                //print(value);
                string[] vec6 = value.Split(',');

                btn1 = int.Parse(vec6[0]);
                btn2 = int.Parse(vec6[1]);
                btn3 = int.Parse(vec6[2]);
                potenc1 = int.Parse(vec6[3]);
                potenc2 = int.Parse(vec6[4]);

                Debug.Log(btn1 + "," + btn2 + "," + btn3 + "," + potenc1 + "," + potenc2);


            }

            catch
            {


            }


        }


    }
    public void EncontrarPuerto()
    {
        if (serialPort == null)
        {
            serialPort = new SerialPort(SerialPort.GetPortNames()[0], 9600);
        }
        else
        {
            return;
        }
    }
}