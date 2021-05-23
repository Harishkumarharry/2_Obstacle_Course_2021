using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Start")
        {
            Debug.Log("Game Started!!!");
        }
        if(collision.gameObject.tag != "Field" && collision.gameObject.tag != "Hit")
        {
            hits++;
        }
        if(collision.gameObject.tag == "Finish")
        {
            Debug.Log("Total Obstacles hit by Ninja: " + hits);
            Debug.Log("Over!!!");
        }
    }

}
