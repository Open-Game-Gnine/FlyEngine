using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debugger.Log("This is a log.");
        Debugger.Log("This is a param:{0} log", "param1");
        Debugger.LogWarning("This is a warning.");
        Debugger.LogError("This is a error.");
        Debugger.LogException(new System.Exception("This is a Exception"));
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
