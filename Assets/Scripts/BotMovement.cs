using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    

    public class BotMovement : MonoBehaviour
    {
        public float botSpeed = 1f;
        public Vector3 velocity;


        // Update is called once per frame
        void Update()
        {
            transform.position += botSpeed* velocity * Time.deltaTime ;
        }
    }

}
