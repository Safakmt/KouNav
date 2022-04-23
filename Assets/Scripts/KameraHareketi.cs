using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KameraHareketi : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform konum;
    public Transform konumCollider;
    private NavMeshAgent nMesh;
    void Start()
    {
        nMesh = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nMesh.destination = konumCollider.position;
        //Debug.Log(nMesh.steeringTarget);
    }
}
