using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textBest;



    // Update is called once per frame
    void Update()
    {
        textBest.text = "Best:" + GameManager.singleton.best;
        textScore.text = "Score:" + GameManager.singleton.score;
    }
}
