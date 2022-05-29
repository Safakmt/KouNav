using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorNameInitalize : MonoBehaviour
{
    
    public TMP_Text tmText;
    void Start()
    {
        tmText.text = name;
    }

}
