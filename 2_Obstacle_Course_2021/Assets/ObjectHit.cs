using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        //Change Assest Color when a player hit any obstacle
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

}
