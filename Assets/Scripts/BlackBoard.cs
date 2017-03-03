using UnityEngine;
using System.Collections;


namespace AI.BehaviourTree
{

    //Contains shared data of the tasks

    public class BlackBoard : MonoBehaviour
    {

        public BotMovement botMovementRef;
        public AIBot_BehaviourTree bot;
        public PlayerBase playerBase;
     
    }
}
