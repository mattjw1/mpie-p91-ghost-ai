using UnityEngine;
using UnityEngine.AI;
public class wander : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public float wanderRadius = 10f;
     public float wanderTimer = 4f;
     private NavMeshAgent agent;
     private float timer;
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();
       timer = wanderTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

    }
}
