using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagement : MonoBehaviour
{

    [SerializeField]
    private Text itemsScoreUI;

    private int score;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        itemsScoreUI.text = score.ToString();
    }

    public void IncreaseScore (int points)
    {
        score += points;
        itemsScoreUI.text = score.ToString();
    }
    
}
