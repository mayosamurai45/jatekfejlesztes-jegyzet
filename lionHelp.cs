using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lionText;

    void Start()
    {
        lionText.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        lionText.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        lionText.enabled = false;
    }
}
