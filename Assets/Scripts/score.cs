using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour
{

    public int Score = 0;
    public Text tracker;
    private string scoreWords = "Score: ";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void counter()
    {
        Score += 1;
        tracker.text = scoreWords + Score;
    }
}
