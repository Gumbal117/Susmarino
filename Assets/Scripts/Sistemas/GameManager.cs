using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool ard;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public void Arduino() 
    {
        if (ard)
        {
            ard = false;
        }
        else if (!ard)
        {
            ard = true;
        }
    }
}
