using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMove : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Vertical")> 0)
        {
            anim.SetBool("moveUp", true);
            anim.SetBool("moveRight", false);
            anim.SetBool("moveDown", false);
        }else if (Input.GetAxisRaw("Vertical") < 0)
        {
            anim.SetBool("moveUp", false);
            anim.SetBool("moveRight", false);
            anim.SetBool("moveDown", true);
        }
        if (Input.GetAxisRaw("Horizontal")>0)
        {
            anim.SetBool("moveUp", false);
            anim.SetBool("moveRight", true);
            anim.SetBool("moveDown", false);
        }
    }
}
