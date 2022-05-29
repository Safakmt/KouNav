using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtons : MonoBehaviour
{

    


    public void MoveForward()
    {
        StartCoroutine(MoveTime());
    }
    public void MoveBackward()
    {

    }
    IEnumerator MoveTime()
    {
        yield return null;
    }
}
