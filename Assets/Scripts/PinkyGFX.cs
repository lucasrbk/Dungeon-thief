using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using System.Collections;

public class PinkyGFX : MonoBehaviour
{
    public Animator animator;
    public AIPath aiPath;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isRunning", false);
        aiPath.canMove = false;
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        while (true)
        {
            print(Time.time);
            yield return new WaitForSeconds(5);
            print(Time.time);
            aiPath.canMove = true;
            animator.SetBool("isRunning", true);

        }
        
    }
    // Update is called once per frame
   
    void FixedUpdate()
    {
        if (aiPath.desiredVelocity.x >= 0.01f)
        {

            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
}
