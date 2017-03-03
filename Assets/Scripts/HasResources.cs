using UnityEngine;
using System.Collections;
using System;


namespace AI.BehaviourTree
{
    public class HasResources : Task
    {
        public override bool Run()
        {
            return blackboardRef.bot.playerCurrentResource > 0;
        }
    }
}
