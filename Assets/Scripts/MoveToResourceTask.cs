using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace AI.BehaviourTree
{

    public class MoveToResourceTask : Task
    {

        public override bool Run()
        {
            Resource[] resources = UnityEngine.Object.FindObjectsOfType<Resource>();

            //Find the closest resource 

            float minDistance = Mathf.Infinity;

            Resource closestResource = null;

            foreach (Resource a in resources)
            {
                float aDistance = (a.transform.position - blackboardRef.botMovementRef.transform.position).sqrMagnitude;
                if (aDistance<minDistance)
                {
                    minDistance = aDistance;
                    closestResource = a;
                }
            }

            Vector3 moveDirection = (closestResource.transform.position - blackboardRef.botMovementRef.transform.position).normalized;

            blackboardRef.botMovementRef.velocity = moveDirection;

            return true;

        }



       
    }
}