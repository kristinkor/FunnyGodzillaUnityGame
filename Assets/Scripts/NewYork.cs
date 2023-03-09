using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewYork : MonoBehaviour
{
   
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
          
            SceneManager.LoadScene("Level2Menu");
            
        }        
    }

}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class NewYork : MonoBehaviour
// {
//     public Animator animator;
//     private int levelToLoad;

//     // Update is called once per frame
//     void Update()
//     {
       
//         FadeToNextLevel();
       
//     }

//     public void FadeToNextLevel(){
//         FadeToLevel(SceneManager.GetAciveScene().buildIndex +1);
//     }

//     public void FadeToLevel (string levelIndex){
//         levelToLoad = levelIndex;
//         animator.SetTrigger("FadeOut");
//     }

//     public void OnFadeComplete(){
   
//         SceneManager.LoadScene(levelToLoad);
//     }
//     // Start is called before the first frame update
// void OnTriggerEnter2D(Collider2D other)
//     {
//         if (other.tag == "Player")
//         {
//             FadeToNextLevel();
//         }        
//     }

// }
