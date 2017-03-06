using UnityEngine;
using System.Collections;

public class ResourceData : MonoBehaviour {

    public int goldAmount = 10;


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("ASD");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ASDFU");

            Destroy(this.gameObject);
            //goldAmount -= 2;
            //if (goldAmount == 0)
            //{

            //}

        }
    }

}
