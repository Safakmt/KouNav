using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SelectionManager : MonoBehaviour
{

    private GameObject[] selectedFromWhere;
    private GameObject[] selectedToWhere;
    private NavMeshAgent nMesh;
    public GameObject player;
    private GameObject cam;

    void Start()
    {
        selectedFromWhere = GameObject.Find("FromWhere").GetComponent<DropDownInitalize>().places;
        selectedToWhere = GameObject.Find("ToWhere").GetComponent<DropDownInitalize>().places;


    }

    public void PlaceFromWhere(int index)
    {
        if(cam != null)
        {
            Destroy(cam);
        }
        if (cam==null)
        {
            Destroy(Camera.main);
        }
        cam = Instantiate(player, selectedFromWhere[index].transform.position, selectedFromWhere[index].transform.rotation);
        Camera cm = cam.GetComponent<Camera>();
        cm = Camera.main;
        nMesh = cam.GetComponent<NavMeshAgent>();
    }

    public void PlaceToWhere(int index)
    {
        Debug.Log(selectedToWhere[index]);
        nMesh.destination = selectedToWhere[index].transform.position;

    }

    public void StopNav()
    {

        if (nMesh == null)
        {
            Debug.Log("hatakeStop");
        }
        else
            nMesh.speed = 0;
    }

    public void StarNav()
    {
        if (nMesh == null)
        {
            Debug.Log("hatakeStart");
        }
        else
            nMesh.speed = 3;
    }


}
