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

    
    private int defaultHighScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        startgame();
        LifeTracker.text = lifeWords + lives;

       
    }


    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            SceneManager.LoadScene("highscore");
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

    private void startgame()
    {
        if (!PlayerPrefs.HasKey("high score 1"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 1", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 2"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 2", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 3"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 3", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 4"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 4", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 5"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 5", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 6"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 6", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 7"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 7", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 8"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 8", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 9"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 9", defaultHighScore); // If it’s not, then save one
        }
        if (!PlayerPrefs.HasKey("high score 10"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("high score 10", defaultHighScore); // If it’s not, then save one
        }

    }

}
