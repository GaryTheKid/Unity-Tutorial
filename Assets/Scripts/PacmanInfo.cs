using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanInfo : MonoBehaviour
{
    private Animator _animator;
    private bool isShown;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        if (isShown)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    public void Hide()
    {
        _animator.SetBool("Show", false);
        isShown = false;
    }

    public void Show()
    {
        _animator.SetBool("Show", true);
        isShown = true;
    }
}
