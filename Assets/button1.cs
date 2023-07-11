using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button1 : MonoBehaviour
{
    public int a = 0;
    public int open = 0;
    public Sprite target_9;
    public Sprite target_0;
    public Sprite target_1;
    public Sprite target_2;
    public Sprite target_3;
    public Sprite target_4;
    public Sprite target_5;
    public Sprite target_6;
    public Sprite target_7;
    public Sprite target_8;
    public void onClick()
    {
        if(a == 0 && open == 0)
        {
            GetComponent<Image>().sprite = target_0;
            startButton.BlocksInMoment--;
        }
        if (a == 1 && open == 0)
        {
            GetComponent<Image>().sprite = target_1;
            startButton.BlocksInMoment--;
        }
        if (a == 2 && open == 0)
        {
            GetComponent<Image>().sprite = target_2;
            startButton.BlocksInMoment--;
        }
        if (a == 3 && open == 0)
        {
            GetComponent<Image>().sprite = target_3;
            startButton.BlocksInMoment--;
        }
        if (a == 4 && open == 0)
        {
            GetComponent<Image>().sprite = target_4;
            startButton.BlocksInMoment--;
        }
        if (a == 5 && open == 0)
        {
            GetComponent<Image>().sprite = target_5;
            startButton.BlocksInMoment--;
        }
        if (a == 6 && open == 0)
        {
            GetComponent<Image>().sprite = target_6;
            startButton.BlocksInMoment--;
        }
        if (a == 7 && open == 0)
        {
            GetComponent<Image>().sprite = target_7;
            startButton.BlocksInMoment--;
        }
        if (a == 8 && open == 0)
        {
            GetComponent<Image>().sprite = target_8;
            startButton.BlocksInMoment--;
        }
        if (a == 9 && open == 0)
        {
            GetComponent<Image>().sprite = target_9;
            startButton.BlocksInMoment--;
            SceneManager.LoadScene(0);
        }
        Debug.Log(startButton.BlocksInMoment);
        if(startButton.BlocksInMoment == 0)
        {
            SceneManager.LoadScene(0);
        }
        open = 1;
    }
}
