using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static int PinCount = 0;
    public Text pinBoard;

    public static int LastScore;
    public Text LastScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        PinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(PinCount > LastScore) 
        {
            LastScore = PinCount;
        }

        pinBoard.text = PinCount.ToString();
        LastScoreBoard.text = $"Last Score: {LastScore.ToString()}";

    }
}
