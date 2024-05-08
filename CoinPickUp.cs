using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinPickUp : MonoBehaviour
{
    private GameObject gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    private void OnTriggerEnter(Collider other)
    {
        gm.GetComponent<GameManager>().coinplus();
        gm.GetComponent<GameManager>().GenerateNewCoin();
        Destroy(this.gameObject);
    }
}
