using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject ReplayButton;
    public GameObject PlayButton;
    Rigidbody2D rb;

    public float speed;
    public float JumpForce;
    public bool isDead;
    public int score;
    public TextMeshProUGUI scoreText;



    void Start()
    {
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (isDead == false)
            {
                rb.velocity = Vector2.right * speed * Time.deltaTime;
                rb.AddForce(Vector2.up * JumpForce);
            }


        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rb.velocity = Vector2.zero;
        ReplayButton.SetActive(true);
        GetComponent<Animator>().SetBool("isDead", true);

    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
    public void UnFreeze()
    {
        Time.timeScale = 1;
        PlayButton.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Score")
        {
            score++;
            Debug.Log(score);
            scoreText.text = score.ToString();
             
        }
    }
}
