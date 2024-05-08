using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int hpLeft = 10;
    [SerializeField] TextMeshProUGUI hpText, statusText, lionText;
    [SerializeField] GameObject bottlePrefab;
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        statusText.enabled = false;
        hpText.SetText("HP: {0}", hpLeft);
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (hpLeft > 0)
        {
            yield return new WaitForSeconds(2);
            hpLeft--;
            hpText.SetText("HP: {0}", hpLeft);
        }

        GameOver(false);
    }

    public void BottlePickedUp()
    {
        hpLeft+=5;
        hpText.SetText("HP: {0}", hpLeft);
        GenerateNewBottle();

        if(hpLeft == 0)
        {
            GameOver(true);
        }
    }

    public void GenerateNewBottle()
    {
        Instantiate(bottlePrefab, new Vector3(Random.Range(-10f, 10f), 0.1f, Random.Range(-10f, 10f)), bottlePrefab.transform.rotation);
    }

    public void GameOver(bool isWin)
    {
        player.GetComponent<PlayerController>().enabled = false;
        statusText.enabled = true;
        if (isWin)
        {
            statusText.SetText("You won!");
        }
    }
}
