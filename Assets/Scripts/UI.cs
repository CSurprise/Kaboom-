using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public Button start;
    public Button main;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        start.onClick.AddListener(() => SceneManager.LoadScene("Game"));
        main.onClick.AddListener(() => SceneManager.LoadScene("titlescreen"));

    }
}
