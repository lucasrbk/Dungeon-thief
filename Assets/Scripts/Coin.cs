using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Score score;
    public AudioClip pickUp;
    private AudioListener listener;

    void Start() {
        score = FindObjectOfType<Score>();
        listener = FindObjectOfType<AudioListener>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                this.score.ScoreUp();
                AudioSource.PlayClipAtPoint(pickUp, listener.transform.position);
                Destroy(this.gameObject);

                break;
        }
    }
}
