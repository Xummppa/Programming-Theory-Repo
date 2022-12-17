using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class DataSaver : MonoBehaviour
{
    // ENCAPSULATION
    public static DataSaver Instance { get; private set; } // add private setter;

    public string PlayerName;



    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}