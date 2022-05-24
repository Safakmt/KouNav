using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDownInitalize : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField selectionInput;
    //private TMP_Dropdown dropdown;
    public GameObject[] places;
    private List<GameObject> names = new List<GameObject>();

    void Awake()
    {
        //dropdown = GetComponent<TMP_Dropdown>();
        PlaceInitalize();
        
    }

    public void PlaceInitalize()
    {
        places = GameObject.FindGameObjectsWithTag("Door");

        if (places != null)
        {
            foreach (GameObject place in places)
            {
                names.Add(place);
            }
        }
    }

    public void InputHandler(TMP_Dropdown dp)
    {
        int index = 0;
        if (selectionInput.text == null)
        {
            foreach (GameObject isim in names)
            {
                  dp.options.Add(new TMP_Dropdown.OptionData()
                  {
                      text = isim.name
                  });
            }
        }
        else
        {
            dp.ClearOptions();
            foreach (GameObject isim in names)
            {
                if (isim.name.ToLower().Contains(selectionInput.text.ToLower()))
                {
                    //selectionmanagerdeki places-index ile dropdowndaki name-index ayni olmasi icin
                    places[index] = isim;
                    index++;
                    dp.options.Add(new TMP_Dropdown.OptionData()
                    {
                        text = isim.name
                    });
                }
            }
            dp.Show();  
        }
        dp.RefreshShownValue();
        
    }

}
