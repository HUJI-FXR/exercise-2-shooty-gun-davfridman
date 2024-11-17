using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GunAimScript : MonoBehaviour
{
    private Vector2 mousePositionScreen, mousePositionWorld;
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindAnyObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePositionScreen = Input.mousePosition;
        mousePositionWorld = mainCamera.ScreenToWorldPoint(mousePositionScreen);
        Vector2 direction = new Vector2(mousePositionWorld.x - transform.position.x,
                                        mousePositionWorld.y - transform.position.y);

        float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle);
    }
}
