using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chacter1 : MonoBehaviour
{
    //this is edit
    public string startMessage; 
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(startMessage);
    }

    //this is edit
    public string updateMessage;
   
    // Update is called once per frame
    void Update()
    {
    Debug.Log(updateMessage);
    }
}
