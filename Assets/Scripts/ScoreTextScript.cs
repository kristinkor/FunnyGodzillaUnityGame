using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    TMP_Text text;
    public static int coinAmount;
    void Start () {
        text = GetComponent<TMP_Text>();

    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
    }
}
