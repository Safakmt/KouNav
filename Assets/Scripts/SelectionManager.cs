using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class SelectionManager : MonoBehaviour
{
    private GameObject[] selectedPlaces;
    private NavMeshAgent nMesh;
    public GameObject player;
    private GameObject cam;

    void Start()
    {
        selectedPlaces = GameObject.Find("ToWhere").GetComponent<DropDownInitalize>().places;

    }


    public void PlaceFromWhere(int index)
    {
        if(cam != null)
        {
            Destroy(cam);
        }
        cam = Instantiate(player, selectedPlaces[index].transform.position, selectedPlaces[index].transform.rotation);
        nMesh = cam.GetComponent<NavMeshAgent>();
    }

    public void PlaceToWhere(int index)
    {
        Debug.Log(selectedPlaces[index]);
        nMesh.destination = selectedPlaces[index].transform.position;

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
            nMesh.speed = 5;
    }
}
