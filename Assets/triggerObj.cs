using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerObj : MonoBehaviour
{
    public Transform spawnPoint;
    public Rigidbody obj;

    void OnTriggerEnter(Collider other){
        Rigidbody newObj = Instantiate(obj, spawnPoint.position, spawnPoint.rotation) as Rigidbody;
    }
}
