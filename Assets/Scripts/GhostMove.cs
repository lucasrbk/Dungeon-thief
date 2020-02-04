using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostMove : MonoBehaviour
{
    public Transform[] waypoints;

    int cur = 0;

    public float speed = 4.0f;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "Player")

            Destroy(co.gameObject);
        PauseMenu.GameIsPaused = true;
             SceneManager.LoadScene("Lvl1");
           
    }
}
