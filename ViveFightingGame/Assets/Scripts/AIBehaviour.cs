using UnityEngine;
using System.Collections;

public class AIBehaviour : MonoBehaviour
{
    private NavMeshAgent m_NMA;

    private GameObject m_Player;

    [SerializeField]
    private float m_ZombieSpeed = 0;

    void Start()
    {
        m_NMA = GetComponent<NavMeshAgent>();
        m_Player = GameObject.Find("PlayerLoc");
        m_NMA.SetDestination(m_Player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        m_NMA.speed = m_ZombieSpeed;
    }
}
