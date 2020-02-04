using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed = 4.0f;
	private Vector2 direction = Vector2.zero;
    

	private Rigidbody2D rb;
	public Animator animator;

    public Transform teleportR;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        

    }
	
	// Update is called once per frame
	void Update () {
		UpdateOrientation ();

	}

	void CheckInput () {
		if (Input.GetKeyDown (KeyCode.A)) {
			direction = Vector2.left;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			direction = Vector2.right;
        } else if (Input.GetKeyDown (KeyCode.W)) {
			direction = Vector2.up;
        } else if (Input.GetKeyDown (KeyCode.S)) {
			direction = Vector2.down;
        }
	}

	void FixedUpdate() {
        CheckInput();
        if ((direction * speed * Time.deltaTime).x != 0 || (direction * speed * Time.deltaTime).y != 0)
            animator.SetBool("isWalking", true);
        else
            animator.SetBool("isWalking", false);
        transform.localPosition += (Vector3)(direction * speed) * Time.deltaTime;

       
	}
	

    void UpdateOrientation () {
		if (direction == Vector2.left) {
			transform.localScale = new Vector3 (-1, 1, 1);
		} else if (direction == Vector2.right) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
		transform.localRotation = Quaternion.Euler (0, 0, 0);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "teleportRight":
                transform.position = new Vector2(-4, 16.5f);
                break;

            case "teleportLeft":
                transform.position = new Vector2(20, 16.5f);
                break;

            case "Walls":
                direction = Vector2.zero;
                 break;

            case "enemy":
                //AudioSource.PlayClipAtPoint(pickUp, listener.transform.position);
                Destroy(this.gameObject);
                SceneManager.LoadScene("Lvl1");
                break;

            case "potion":
                this.speed = 6f;
                StartCoroutine(Wait(3));
                
                break;
            case "Espinho":
                Destroy(this.gameObject);
                SceneManager.LoadScene("Lvl1");
                break;
           
            default:
            break;
        }

       


    }

    IEnumerator Wait(float s)
    {
       
            
            yield return new WaitForSeconds(s);
            print(Time.time);
            this.speed = 4f;

    }


}

