using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileKeyboard : MonoBehaviour
{
    TouchScreenKeyboard klavye;
    public void OpenKlavye() {

        klavye = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
