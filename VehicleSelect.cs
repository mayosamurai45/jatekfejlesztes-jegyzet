using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class VehicleSelect : MonoBehaviour
{
    public GameObject[] cars;
    [SerializeField] TextMeshProUGUI selectText;
    GameObject fp, gm;

    void Start()
    {
        fp = GameObject.Find("Main Camera");
        gm = GameObject.Find("GameManager");
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            GameObject car = Instantiate(cars[0], Vector3.zero, Quaternion.identity);
            fp.GetComponent<FollowPlayer>().Player();
            GetComponent<VehicleSelect>().enabled = false;
            selectText.enabled = false;
            gm.GetComponent<GameManager>().StartCount();

        }
        else if (Input.GetKeyDown("2"))
        {
            GameObject car = Instantiate(cars[1], Vector3.zero, Quaternion.identity);
            fp.GetComponent<FollowPlayer>().Player();
            GetComponent<VehicleSelect>().enabled = false;
            selectText.enabled = false;
            gm.GetComponent<GameManager>().StartCount();
        }
    }
}