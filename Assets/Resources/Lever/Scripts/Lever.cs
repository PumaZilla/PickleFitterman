using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public float value;
    [SerializeField] private float minValue, maxValue;

    void Update()
    {
        float clamp = Mathf.Clamp(transform.position.y, minValue, maxValue);
        value = (clamp - minValue) / (maxValue - minValue);
    }
}
