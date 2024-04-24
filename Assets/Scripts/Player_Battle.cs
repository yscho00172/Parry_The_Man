using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Battle : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) animator.SetBool("IsParrying", true);
        if (Input.GetMouseButtonUp(0)) animator.SetBool("IsParrying", false);
    }
}
