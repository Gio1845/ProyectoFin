using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    private NavMeshAgent nav;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        nav = GetComponent<NavMeshAgent>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance (player.position, this.transform.position) < 12)
        {
            print("Player in rage");
            nav.SetDestination(player.position);
        }

    }
}
