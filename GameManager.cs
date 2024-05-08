using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    int coins, hpLeft;
    [SerializeField] TextMeshProUGUI hpText, statusText;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void StartCount() 
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            hpLeft++;
            hpText.SetText("Time: {0}", hpLeft);
        }
    }

    public void GenerateNewCoin()
    {
      Instantiate(prefab, new Vector3(Random.Range(-15f, 20f), 0.1f, Random.Range(10f, 150f)), prefab.transform.rotation);
    }

    public void coinplus()
    {
        if (coins != 1) 
        {
            coins++;
        }
        else
        { 
            statusText.SetText("NYERÉTL bameg!!!");
            Time.timeScale = 0;
        }
    }

    public void endgame()
    {
        statusText.SetText("VESZTETTÉL BAMEG!");
        Time.timeScale = 0;
    }
}
