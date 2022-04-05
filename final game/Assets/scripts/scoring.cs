using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    public Text MyScore;
    private int scoreNum;

    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        MyScore.text = "Score" + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        scoreNum += 1;
        Destroy(Coin.gameObject);
        MyScore.text = "Score" + scoreNum;

    }
}
