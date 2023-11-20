using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TextMeshProUGUI;
public class score : MonoBehaviour
{
    public int initiallScore = 0;
    public int currscore;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        currscore = initiallScore;
        _text = this.GetComponent<Text>();
        _text.text = "SCORE: " + currscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScoreAndDisplay()
    {
        currscore += 100;
        _text.text = "SCORE: " + currscore.ToString();
    }
    public void SubScoreAndDisplay()
    {
        currscore -= 100;
        _text.text = "SCORE: " + currscore.ToString();
    }
}
