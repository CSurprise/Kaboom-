using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class score : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip thud;

    private int Score = 0;
    private int lives = 3;
    public Text tracker;
    public Text LifeTracker;
    private string scoreWords = "Score: ";
    private string lifeWords = "Lives: ";
    // Start is called before the first frame update
    void Start()
    {
        LifeTracker.text = lifeWords + lives;
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("titlescreen");
        }
    }

    void counter()
    {
        Score += 1;
        tracker.text = scoreWords + Score;
    }

    void life()
    {
        lives -= 1;
        LifeTracker.text = lifeWords + lives;


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        life();
        sound.PlayOneShot(thud);
    }
}
