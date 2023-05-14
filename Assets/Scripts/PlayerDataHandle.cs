using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Singleton 
    public static PlayerDataHandle Instance;
    public string PlayerName;
    public int Score;

    private void Awake()
    {
        //I want to cry
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}