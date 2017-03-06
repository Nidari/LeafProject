using UnityEngine;
using System.Collections;



namespace AI.BehaviourTree
{
    public class ResourceSpawner : MonoBehaviour
    {

        public Transform[] spawnPoints;
        public float spawnTime = 1.5f;
        public GameObject Gold;

        // Use this for initialization
        void Start()
        {
            InvokeRepeating("SpawnResource", spawnTime, spawnTime);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SpawnResource()
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(Gold, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
        }


    }
}
