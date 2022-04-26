using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ControlCamera_2 : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public float zoomSpeed = 10.0f;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }
    void Update()
    {
        Zoom();
        Rotate();
  
    }
    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }
    }

    private void Rotate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 rot = transform.rotation.eulerAngles;
            rot.y += speedH * Input.GetAxis("Mouse X");
           


            rot.y = Mathf.Clamp(rot.y, 20f, 155f);

            Quaternion q = Quaternion.Euler(rot); // Quaternion으로 변환
            q.z = 0;

            transform.eulerAngles = new Vector3(pitch, rot.y, 0.0f);
        }
    }
}