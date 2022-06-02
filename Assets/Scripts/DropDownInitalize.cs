using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDownInitalize : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField selectionInput;
    public GameObject[] places;
    private List<GameObject> names = new List<GameObject>();
    private TMP_Dropdown dropd;

    void Awake()
    {
        dropd = GetComponent<TMP_Dropdown>();
        PlaceInitalize(dropd);
        
    }

    public void PlaceInitalize(TMP_Dropdown dd)
    {
        places = GameObject.FindGameObjectsWithTag("Door");
        if (places != null)
        {
            foreach (GameObject place in places)
            {
                names.Add(place);
                dd.options.Add(new TMP_Dropdown.OptionData()
                {
                    text = place.name
                });
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
        dp.value = -1;
    }

}
