using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresenterController : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;
    private CharacterController _characterController;
    private int dir;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // player input
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // movement
        _characterController.Move(new Vector3(x, 0f, y) * Time.deltaTime * moveSpeed);

        // update animator
        if ((int)x != 0)
        {
            dir = (int)x;
        }
        animator.SetInteger("MoveX", dir);

        // emote
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Emote();
        }
    }

    private void Emote()
    {
        animator.SetTrigger("Emote");
    }
}