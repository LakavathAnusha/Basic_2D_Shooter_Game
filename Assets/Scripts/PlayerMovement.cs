using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    float score;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(x, y, 0) * (speed * Time.deltaTime));

       
    }
    public void ScoreCalculator(int value)
    {
        score = score + value;
        scoreText.text = score.ToString();
        Debug.Log(score);
       
    }
}
