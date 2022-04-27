using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDownInitalize : MonoBehaviour
{
    private TMP_Dropdown dropdown;
    public GameObject[] places;
    private List<string> names = new List<string>();

    void Awake()
    {
        dropdown = GetComponent<TMP_Dropdown>();
        PlaceInitalize(dropdown);
    }

    public void PlaceInitalize(TMP_Dropdown dp)
    {
        places = GameObject.FindGameObjectsWithTag("Door");

        if (places != null)
        {
            foreach (GameObject place in places)
            {
                names.Add(place.name);
            }
            dropdown.AddOptions(names);
        }
    }

}
