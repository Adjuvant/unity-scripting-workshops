using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class AnimationTrigger : MonoBehaviour
{
    [Tooltip("Enter the object with that should be animated based on triggering")]
    public Animator target;

    [Tooltip("Enter the name of the animation to trigger when an object enters trigger volume")]
    public string animationString;

    // Start is called before the first frame update
    private void Start()
    {
        if (!target) Debug.LogError("This script needs a target animator for the triggering to work.");
    }

    private void OnTriggerEnter(Collider other)
    {
        target.Play(animationString);
    }
}