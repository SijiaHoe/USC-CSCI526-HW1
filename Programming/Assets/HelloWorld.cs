using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myMessage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log(myMessage);
    }
}
