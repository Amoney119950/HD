using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransfrom;

    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent> ();
    }

    private void Update()
    { 
        navMeshAgent.destination = movePositionTransfrom.position;
    }
}
