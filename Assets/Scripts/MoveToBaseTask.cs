using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;


namespace AI.BehaviourTree
{
    public class MoveToBaseTask : Task

    {
        public override bool Run()
        {

            Vector3 playerToBot =
                (blackboardRef.bot.transform.position
                    - blackboardRef.playerBase.transform.position).normalized;
            blackboardRef.botMovementRef.velocity = -playerToBot;
            return true;


        }

    }
}

