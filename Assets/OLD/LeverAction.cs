using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAction : MonoBehaviour
{
    [SerializeField] private GameObject gato;
    [SerializeField] private float animationSpeed = 5f;
    [SerializeField] private float sensibility = 10f;
    [SerializeField] private float step = .001f;
    private float max_height = 0.5f, min_height = -0.5f;

    private float currentHeight, targetHeight;




    void Update()
    {
        if (Mathf.Abs(transform.rotation.x) > sensibility)
        {
            if (transform.rotation.x > 0 && targetHeight <= max_height)
            {
                targetHeight += step;
            }
            else if (transform.rotation.x < 0 && targetHeight > min_height)
            {
                targetHeight -= step;
            }
        }
        else
        {
            targetHeight = currentHeight;
        }
        if (currentHeight != targetHeight)
        {
            currentHeight = Mathf.Lerp(currentHeight, targetHeight, Time.deltaTime * animationSpeed);
            gato.transform.position = new Vector3(gato.transform.position.x, currentHeight, gato.transform.position.z);
        }
    }
}
