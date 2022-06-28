using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static int numberOfCoins;
    public Text coinsText;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCoins = 0;
        gameOver = false;
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        Debug.Log(coinsText);
        coinsText.text = "Coins: " + numberOfCoins;
        Destroy(gameObject);
    }

}
