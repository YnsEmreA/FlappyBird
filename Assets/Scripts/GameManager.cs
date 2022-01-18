using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTMP;
    [SerializeField] private GameObject playButton , gameOver;
    [SerializeField] private Bird bird;
    private int score;

    private void Awake() 
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play()
    {
        score = 0;
        scoreTMP.text = score.ToString();
        playButton.SetActive(false);
        gameOver.SetActive(false);
        Time.timeScale = 1f;
        bird.enabled = true;
        
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

    }
    public void Pause()
    {
        Time.timeScale = 0f;
        bird.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    public void Score()
    {
        score++;
        scoreTMP.text = score.ToString();
    }
}
