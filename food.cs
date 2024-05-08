using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public GameObject[] foods;
    GameObject activeFood;

    // Start is called before the first frame update
    void Start()
    {
        activeFood = foods[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            activeFood = foods[0];
        }
        else if (Input.GetKeyDown("2"))
        {
            activeFood = foods[1];
        }
        else if (Input.GetKeyDown("3"))
        {
            activeFood = foods[2];
        }

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(activeFood, transform.position + new Vector3(0, 1, 1), Quaternion.identity);
        }
    }
}
