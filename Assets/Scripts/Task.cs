using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace AI.BehaviourTree
{

    public abstract class Task
    {
        public BlackBoard blackboardRef;
        public List<Task> children = new List<Task>();

        public abstract bool Run();
     
    }
}