using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide_an2 : MonoBehaviour
{
    public GameObject container;
    
    public void ShowHide()
    {
        if ( container != null)
        {
            Animator animator = container.GetComponent<Animator>();
            if (animator != null)
            {
                bool IsClicked = animator.GetBool("Moves");
                animator.SetBool("Moves", false);
            }
        }
    }
}
