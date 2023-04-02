using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraiEffect : MonoBehaviour
{
    private TrailRenderer trail;
    private Transform mousePos;
    private bool isPress = false;
    void Start()
    {
        trail = GetComponent<TrailRenderer>();   
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = mousePos;
        if (Input.GetButton("Fire1"))
        {
            isPress = true;
        }
        if (Input.GetButtonUp("Fire1"))
        {
            isPress = false;
        }

        trail.emitting = isPress;
    }
}
