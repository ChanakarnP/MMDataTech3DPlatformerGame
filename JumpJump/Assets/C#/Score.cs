using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreT;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "coin")
        {
            score++;
            scoreT.text = "Score = " + score;
            Destroy(other.gameObject);
            if (score == 62)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }
    

}
