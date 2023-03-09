using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("work!");
        if(other.tag == "Player" || other.tag == "Player1"){
            ScoreTextScript.coinAmount = 0;
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
}
