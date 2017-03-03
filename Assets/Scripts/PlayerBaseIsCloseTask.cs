using UnityEngine;
using System.Collections;

namespace AI.BehaviourTree
{
    public class PlayerBaseIsCloseTask : Task
    {
        public float threshold = 1;

        public override bool Run()
        {
            float distance = (blackboardRef.bot.transform.position
                    - blackboardRef.playerBase.transform.position).magnitude;
            return distance < threshold;
        }
    }
}