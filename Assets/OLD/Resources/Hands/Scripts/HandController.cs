using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour {

    [SerializeField]
    private Hand hand;
    private ActionBasedController controller;

    private void Start() {
        controller = GetComponent<ActionBasedController>();
    }

    private void Update() {
        // update the trigger value
        hand.SetTrigger(controller.selectAction.action.ReadValue<float>());
        // update the grip value
        hand.SetGrip(controller.activateAction.action.ReadValue<float>());
    }
}
