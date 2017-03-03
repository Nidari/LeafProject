using UnityEngine;
using System.Collections;
using System;

namespace AI.BehaviourTree
{

    public class Gold : Task
    {
        public override bool Run()
        {
            blackboardRef.bot.Gold();
            return true;
        }
    }

}