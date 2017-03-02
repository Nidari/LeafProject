using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{

    public class BotMovement : MonoBehaviour
    {

        public Vector3 velocity;

        // Update is called once per frame
        void Update()
        {
            transform.position += velocity * Time.deltaTime;
        }
    }

}
