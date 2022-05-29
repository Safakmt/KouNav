using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathLineDrawer : MonoBehaviour
{
    private LineRenderer liner;
    private NavMeshAgent navMeshAgent;
    void Start()
    {
        liner = GetComponent<LineRenderer>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        liner.positionCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        DrawPath();
    }

    void DrawPath()
    {
        liner.positionCount = navMeshAgent.path.corners.Length;
        liner.SetPosition(0, transform.position);

        if (navMeshAgent.path.corners.Length < 2)
        {
            return;
        }

        for (int i = 1; i < navMeshAgent.path.corners.Length; i++)
        {
            Vector3 pointPos = new Vector3(navMeshAgent.path.corners[i].x, navMeshAgent.path.corners[i].y+1 , navMeshAgent.path.corners[i].z);
            liner.SetPosition(i, pointPos);
        }

    }
}
