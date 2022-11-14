using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI

    [RequireComponent(typeof(NavMeshAgent))]
public class followDestination : MonoBehaviour
{
    public Transform Destination = null;
    private NavMeshAgent ThisAgent = null;
   
    void Awake()
    {
        ThisAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        ThisAgent.SetDestination(Destination.position);
    }
}
