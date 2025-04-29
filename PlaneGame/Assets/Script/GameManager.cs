using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    static GameManager instance;
    private int curscore = 0;

    UIManager uiManger;
    public UIManager uIManager { get { return uiManger; } }
    public static GameManager Instance { get { return instance; } } 
    private void Awake()
    {
        instance = this;
        uiManger = FindObjectOfType<UIManager>();
    }


   public void GameOver()
    {

        uiManger.SetRestart();
        Debug.Log("게임 오버");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void AddScore(int score)
    {
        curscore += score;
        uiManger.UpdateScore(curscore);
    }
}
