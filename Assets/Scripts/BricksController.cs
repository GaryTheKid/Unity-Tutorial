using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksController : MonoBehaviour
{
    public List<Rigidbody> brickList;
    public List<Rigidbody> houseBrickList;
    public Animator blueprintAnimator;

    public void FreeBricks()
    {
        foreach (Rigidbody brick in brickList)
        {
            brick.isKinematic = false;
        }
    }

    public void BuildHouse()
    {
        blueprintAnimator.SetTrigger("Show");
        foreach (Rigidbody brick in houseBrickList)
        {
            brick.isKinematic = false;
        }
    }
}
