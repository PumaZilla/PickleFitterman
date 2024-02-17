using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour {

    [SerializeField]
    private float animationSpeed = 10f;

    private Animator animator;
    private float currentGrip, targetGrip, currentTrigger, targetTrigger;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        SmoothlyAnimate();
    }

    internal void SetTrigger(float value) {
        targetGrip = value;
    }

    internal void SetGrip(float value) {
        targetTrigger = value;
    }

    private void SmoothlyAnimate() {
        if (currentGrip != targetGrip) {
            currentGrip = Mathf.Lerp(currentGrip, targetGrip, Time.deltaTime * animationSpeed);
            animator.SetFloat("Grip", currentGrip);
        }
        if (currentTrigger != targetTrigger) {
            currentTrigger = Mathf.Lerp(currentTrigger, targetTrigger, Time.deltaTime * animationSpeed);
            animator.SetFloat("Trigger", currentTrigger);
        }
    }

    
}
