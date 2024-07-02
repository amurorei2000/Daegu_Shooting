using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singletone Pattern class
    // static ����
    public static GameManager gm;

    public ScoreUI scoreUI;
    
    int currentScore;
    

    void Awake()
    {
        // ���� �� �� ���� �����ϵ��� ó��
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
        // ���� ǥ�� �ʱ�ȭ
        AddScore(0);   
    }

    // ������ �߰��ϰ�, ����� ������ UI�� ����Ѵ�.
    public void AddScore(int point)
    {
        // 1. ������ �����Ѵ�.
        currentScore += point;

        // 2. ������ UI�� ����Ѵ�.
        scoreUI.text_currentScore.text = currentScore.ToString();
    }
   
}
