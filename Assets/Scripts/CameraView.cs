using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;

    public Vector2 sensitivity = Vector2.one * 360f;
    float screenCenter;

    void Awake()
    {
        screenCenter = new Vector2(Screen.width, Screen.height).magnitude / 2f;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Start()
    {

    }

    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity.x;
        rotationX += Input.GetAxis("Mouse Y") * Time.deltaTime * -1 * sensitivity.y;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
