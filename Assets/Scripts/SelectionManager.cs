using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SelectionManager : MonoBehaviour
{
    public List<Vector3> previousMoves;
    private GameObject[] selectedFromWhere;
    private GameObject[] selectedToWhere;
    private NavMeshAgent nMesh;
    public GameObject player;
    private GameObject cam;
    private int selectedindex;

    void Start()
    {
        selectedFromWhere = GameObject.Find("FromWhere").GetComponent<DropDownInitalize>().places;
        selectedToWhere = GameObject.Find("ToWhere").GetComponent<DropDownInitalize>().places;
        previousMoves = new List<Vector3>();
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
        
        previousMoves.Clear();

    }

    public void PlaceToWhere(int index)
    {
        Debug.Log(selectedToWhere[index]);
        nMesh.destination = selectedToWhere[index].transform.position;
        selectedindex = index;
    }

    public void StopNav()
    {

        if (nMesh == null)
        {
            Debug.Log("hatakeStop");
        }
        else
        {
            previousMoves.Add(cam.transform.position);
            nMesh.speed = 0;
        }
    }

    public void StarNav()
    {
        if (nMesh == null)
        {
            Debug.Log("hatakeStart");
        }
        else
        {
            previousMoves.Add(cam.transform.position);
            nMesh.speed = 3;
        }
    }

    public void MoveForward()
    {
        if (previousMoves.Count == 0)
        {
            previousMoves.Add(cam.transform.position);
        }
        StartCoroutine(MoveTime());
    }

    IEnumerator MoveTime()
    {
        nMesh.speed = 4f;
        yield return new WaitForSeconds(3f);
        nMesh.speed = 0;
        previousMoves.Add(cam.transform.position);
    }

    public void MoveBackward()
    {
        if (previousMoves.Count > 1)
        {
            nMesh.enabled = false;
            cam.transform.position = previousMoves[previousMoves.Count - 2];
            previousMoves.RemoveAt(previousMoves.Count - 1);
            //previousMoves.RemoveAt(previousMoves.Count - 1);
            nMesh.enabled = true;
            nMesh.SetDestination(selectedToWhere[selectedindex].transform.position);
        }
        else if (previousMoves.Count == 1)
        {
            nMesh.enabled = false;
            cam.transform.position = previousMoves[previousMoves.Count - 1];
            previousMoves.RemoveAt(previousMoves.Count - 1);
            nMesh.enabled = true;
            nMesh.SetDestination(selectedToWhere[selectedindex].transform.position);
        }
    }
    
}
