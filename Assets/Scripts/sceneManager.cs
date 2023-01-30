using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class sceneManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static sceneManager Instance { get; private set; }

    public string userName; // new variable declared

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
        getUserName();
    }

    private void getUserName() 
    { 

    }
 
}
