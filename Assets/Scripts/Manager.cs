using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject[] Places;
    void Start()
    {
        Places = GameObject.FindGameObjectsWithTag("Door");
        foreach(GameObject place in Places)
        {
            Debug.Log(place.GetInstanceID());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
