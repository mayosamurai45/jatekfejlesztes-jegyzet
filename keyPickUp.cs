using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPickUp : MonoBehaviour
{
    private GameObject gm;
    
    private void Start()
    {
        gm = GameObject.Find("Chest closed");
    }
    private void OnTriggerEnter(Collider other)
    {
        gm.GetComponent<box>().openBox();
        Destroy(this.gameObject);
    }
}
