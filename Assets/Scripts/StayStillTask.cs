using UnityEngine;
using System.Collections;
namespace AI.BehaviourTree
{
    public class StayStillTask : Task
    {
        public override bool Run()
        {
            blackboardRef.botMovementRef.velocity = Vector3.zero;
            return true;
        }
    }
}