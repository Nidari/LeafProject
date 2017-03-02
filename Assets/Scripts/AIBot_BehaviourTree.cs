using UnityEngine;
using System.Collections;


namespace AI.BehaviourTree
{

    public class AIBot_BehaviourTree : MonoBehaviour
    {

        public int playerCurrentResource;
        public ResourceData resourceDataRef;

        private Task rootTask;

        // Use this for initialization
        void Awake()
        {
            
            BlackBoard blackBoardRef = GetComponent<BlackBoard>();

           resourceDataRef= GameObject.FindGameObjectWithTag("ResourceGold").GetComponent<ResourceData>();

            // Create the Nodes

            var mainSelTask = new SelectorTask();
            mainSelTask.blackboardRef = blackBoardRef;

            var seqResourceTask = new SequenceTask();
            seqResourceTask.blackboardRef = blackBoardRef;


            var moveToResource = new MoveToResourceTask();
            moveToResource.blackboardRef = blackBoardRef;


            //Connect the nodes to generate the tree
            rootTask = mainSelTask;
            mainSelTask.children.Add(seqResourceTask);
            seqResourceTask.children.Add(moveToResource);
            
           
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
                this.playerCurrentResource += 2;
                Debug.Log("Stealing");
            }
        }

    }

}
