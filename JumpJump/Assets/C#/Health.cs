using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int scoreH;
    public Text scoreT;
    // Start is called before the first frame update
    void Start()
    {
        scoreH = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enermy")
        {
            scoreH-=5;
            scoreT.text = "Health = " + scoreH;
            Destroy(other.gameObject);
            if (scoreH == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    
}
