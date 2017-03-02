using UnityEngine;
using System.Collections;

public class ResourceData : MonoBehaviour {

    public int goldAmount = 10;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {
            goldAmount -= 2;
            if (goldAmount == 0)
            {
                Destroy(this.gameObject);
            }
           
        }
    }
}
