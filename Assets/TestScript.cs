using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    int spacebar = 0;
    public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {

        ScoreText.GetComponent<Text>().text = "SpaceBar:" + spacebar;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ScoreText.GetComponent<Text>().text = "SpaceBar:" + spacebar;
            print("SpaceBar is pressed");
            spacebar++;
        }
       else if(Input.GetKeyUp(KeyCode.Space))
        {
            print("SpaceBar is released");
        }
    }
}
