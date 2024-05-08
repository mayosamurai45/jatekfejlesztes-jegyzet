using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class box : MonoBehaviour
{
    private bool boxopened = false;
    [SerializeField] TextMeshProUGUI statusText;
    public GameObject boxPrefab;

    public void openBox()
    {
        boxopened = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (boxopened == true)
        {
            Instantiate(boxPrefab,transform.position, transform.rotation);
            statusText.enabled = true;
            Destroy(this.gameObject);
            statusText.SetText("You win!!!");
            
        }
    }
}
