using UnityEngine;
using System.Collections;


namespace AI.BehaviourTree
{

    public class AIBot_BehaviourTree : MonoBehaviour
    {
        public int playerCurrentResource;
        public ResourceData resourceDataRef;

        private Task rootTask;
       
        void Awake()
        {

            BlackBoard blackBoardRef = GetComponent<BlackBoard>();

            resourceDataRef = GameObject.FindGameObjectWithTag("ResourceGold").GetComponent<ResourceData>();

            // Create the Nodes

            var mainSelTask = new SelectorTask();
            mainSelTask.blackboardRef = blackBoardRef;

            var seqResourceTask = new SequenceTask();
            seqResourceTask.blackboardRef = blackBoardRef;

            var seqBaseTask = new SequenceTask();
            seqBaseTask.blackboardRef = blackBoardRef;

            var moveToResource = new MoveToResourceTask();
            moveToResource.blackboardRef = blackBoardRef;

            var moveToBase = new MoveToBaseTask();
            moveToBase.blackboardRef = blackBoardRef;

            var notTask = new NotTask();
            notTask.blackboardRef = blackBoardRef;

            var hasResourceTask = new HasResources();
            hasResourceTask.blackboardRef = blackBoardRef;

            var playerBaseCloseTask = new PlayerBaseIsCloseTask();
            playerBaseCloseTask.blackboardRef = blackBoardRef;

            var stayTask = new StayStillTask();
            stayTask.blackboardRef = blackBoardRef;

            var forTask = new ForTask();
            forTask.blackboardRef = blackBoardRef;

            var waitTask = new WaitTask();
            waitTask.blackboardRef = blackBoardRef;

            var goldTask = new Gold();
            goldTask.blackboardRef = blackBoardRef;


            //Connect the nodes to generate the tree
            rootTask = mainSelTask;
            mainSelTask.children.Add(seqResourceTask);
            mainSelTask.children.Add(seqBaseTask);
            mainSelTask.children.Add(moveToBase);

            seqResourceTask.children.Add(notTask);
            notTask.children.Add(hasResourceTask);
            seqResourceTask.children.Add(moveToResource);

            seqBaseTask.children.Add(playerBaseCloseTask);
            seqBaseTask.children.Add(stayTask);
            seqBaseTask.children.Add(forTask);

            forTask.children.Add(waitTask);
            waitTask.children.Add(goldTask);


        }
        public void Start()
        {
            StartCoroutine(TickAICO());
        }


        public IEnumerator TickAICO()
        {
            while (true)
            {
                rootTask.Run();
                yield return null;
            }
        }


        public void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Resource>())
            {
                this.playerCurrentResource += 10;

            }
        }

        public void Gold()
        {
            if (this.playerCurrentResource > 0)
            {
                this.playerCurrentResource -= 1;
                Debug.Log("Stealing");
            }
        }

    }

}
