using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player1 player;
    private Spawner spawner;
    public float timeStart = 15f;

    public Text textBox;

    public Text scoreText;
    // public GameObject playButton;
    // public GameObject gameOver;

    public int score { get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player1>();
        spawner = FindObjectOfType<Spawner>();
        
        //Pause();
    }

    void UpdateTime(){
        textBox.text = timeStart.ToString();
        timeStart -=Time.deltaTime;
        textBox.text=Mathf.Round(timeStart).ToString();
        Debug.Log(timeStart);
        if(Mathf.Round(timeStart)==0){
            SceneManager.LoadScene("Win", LoadSceneMode.Single);
        }

    }

    void Update(){
        UpdateTime();
    }
   

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        //playButton.SetActive(false);
        //gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Obstacles[] obstacles = FindObjectsOfType<Obstacles>();

        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i].gameObject);
        }
    }

    // public void GameOver()
    // {
    //     //playButton.SetActive(true);
    //    //gameOver.SetActive(true);

    //     Pause();
    // }

    // public void Pause()
    // {
    //     Time.timeScale = 0f;
    //     player.enabled = false;
    // }

    public void IncreaseScore()
    {
        ScoreTextScript.coinAmount +=1;
        score++;
        scoreText.text = score.ToString();
    }

}