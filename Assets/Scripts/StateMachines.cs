using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
      
    void Update()
    {
        Idle();
    }
    void onTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Water")
        {
            Swimming();
        }
    }
    void Swimming()
    {
        Debug.Log("I am Swimming");
    }
    void Climbing()
    {
        Debug.Log("I am Climbing");
    }
    void Idle()
    {
        Debug.Log("I am Idle");
    }
}
