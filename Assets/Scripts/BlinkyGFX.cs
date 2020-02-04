using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class BlinkyGFX : MonoBehaviour
{
    public Animator animator;
    public AIPath aiPath;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
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
    void FixedUpdate()
        {
            if(aiPath.maxSpeed > 0)
            {
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }
        }
    }

