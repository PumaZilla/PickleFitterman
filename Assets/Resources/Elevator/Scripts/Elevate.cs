using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevate : MonoBehaviour
{
    [SerializeField] private Lever lever;
    [SerializeField] private float minY, maxY;

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Lerp(minY, maxY, lever.value);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
