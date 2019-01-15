using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWall : MonoBehaviour {
    
    private void OnCollisionEnter(Collision collision)
    {
        int a = 1;
        if(collision.transform.tag == "wall")
        {
            Debug.Log("syoutotu");
        }
    }

}
