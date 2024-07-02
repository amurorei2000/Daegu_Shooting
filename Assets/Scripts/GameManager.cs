using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singletone Pattern class
    // static 변수
    public static GameManager gm;

    public ScoreUI scoreUI;
    
    int currentScore;
    

    void Awake()
    {
        // 씬에 단 한 개만 존재하도록 처리
        if (gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // 점수 표시 초기화
        AddScore(0);   
    }

    // 점수를 추가하고, 변경된 점수를 UI에 출력한다.
    public void AddScore(int point)
    {
        // 1. 점수를 누적한다.
        currentScore += point;

        // 2. 점수를 UI에 출력한다.
        scoreUI.text_currentScore.text = currentScore.ToString();
    }
   
}
