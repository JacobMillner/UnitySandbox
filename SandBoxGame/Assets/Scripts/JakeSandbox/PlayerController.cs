using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed;

    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            anim.SetBool("Moving", true);

            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            anim.SetBool("Moving", true);

            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * MoveSpeed * Time.deltaTime, 0f));
        }

        // If we detect 0 axis changes then set animation to idle
        if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0)
        {
            anim.SetBool("Moving", false);            
        }
    }
}
