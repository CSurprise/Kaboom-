using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class hishscore : MonoBehaviour
{
    public Text one, two, three, four, five, six, seven, eight, nine, ten;
    private string first = "1. ";
    private string second = "2. ";
    private string third = "3. ";
    private string fourth = "4. ";
    private string fifth = "5. ";
    private string sixth = "6. ";
    private string seventh = "7. ";
    private string eighth = "8. ";
    private string nineth = "9. ";
    private string tenth = "10. ";


    // Start is called before the first frame update
    void Start()
    {
        one.text = first + PlayerPrefs.GetInt("high score 1");
        two.text = second + PlayerPrefs.GetInt("high score 2");
        three.text = third + PlayerPrefs.GetInt("high score 3");
        four.text = fourth + PlayerPrefs.GetInt("high score 4");
        five.text = fifth + PlayerPrefs.GetInt("high score 5");
        six.text = sixth + PlayerPrefs.GetInt("high score 6");
        seven.text = seventh + PlayerPrefs.GetInt("high score 7");
        eight.text = eighth + PlayerPrefs.GetInt("high score 8");
        nine.text = nineth + PlayerPrefs.GetInt("high score 9");
        ten.text = tenth + PlayerPrefs.GetInt("high score 10");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
