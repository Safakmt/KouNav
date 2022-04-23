using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SelectionManager : MonoBehaviour
{
    private GameObject[] places;
    private List<string> names = new List<string>();
    void Start()
    {
        
        TMP_Dropdown dropdown = GetComponent<TMP_Dropdown>();
        places = GameObject.FindGameObjectsWithTag("Door");

        if (places != null)
        {
            
            foreach (GameObject place in places)
            {
                names.Add(place.name);
                //Debug.Log(place.name);
            }
            dropdown.AddOptions(names);
        }
        else
        {
            Debug.Log("asdawdasd");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
