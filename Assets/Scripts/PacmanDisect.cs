using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanDisect : MonoBehaviour
{
    private Animator _animator;
    private bool isDisected;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (isDisected)
        {
            Restore();
        }
        else
        {
            Disect();
        }
    }

    public void Restore()
    {
        _animator.SetBool("Disect", false);
        isDisected = false;
    }

    public void Disect()
    {
        _animator.SetBool("Disect", true);
        isDisected = true;
    }
}
