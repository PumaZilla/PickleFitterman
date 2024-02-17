/**
 * This script is used to animate the hands of the player. It uses the grip and trigger values from the input system to animate the hands.
 * The animation speed can be adjusted to make the animation more smooth or more snappy.
 * 
 * The script is attached to the hands of the player.
 * 
 * The script requires an Animator component to work.
 * 
 * The script also requires the Input System package to work.
 *
 * Reference: https://www.youtube.com/watch?v=vGZlTfZIfRo
 */

using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class HandsAnimation : MonoBehaviour
{
    private Animator animator;
    private float currentGrip, currentTrigger;
    [SerializeField] private float animationSpeed = 15f;
    [SerializeField] private InputActionReference gripAction, triggerAction;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        currentGrip = Mathf.Lerp(currentGrip, gripAction.action.ReadValue<float>(), Time.deltaTime * animationSpeed);
        animator.SetFloat("Grip", currentGrip);

        currentTrigger = Mathf.Lerp(currentTrigger, triggerAction.action.ReadValue<float>(), Time.deltaTime * animationSpeed);
        animator.SetFloat("Trigger", currentTrigger);
    }
}
