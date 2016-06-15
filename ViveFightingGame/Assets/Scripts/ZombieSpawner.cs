using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    private float m_SpawnSpeed;
    [SerializeField]
    private float m_Timer;
    [SerializeField]
    private GameObject m_PrefabToSpawn;
    [SerializeField]
    private GameObject[] m_SpawnPoints;

    void Start()
    {

    }

    void Update()
    {
        m_Timer -= Time.deltaTime;
        if(m_Timer <= 0)
        {
            int spawnPos = Random.Range(0, m_SpawnPoints.Length);
            GameObject zombie = Instantiate(m_PrefabToSpawn, m_SpawnPoints[spawnPos].transform.position, Quaternion.identity) as GameObject;
            m_Timer = m_SpawnSpeed;
        }
    }
}
