using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{

    // Use this for initialization
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseX;

    public float sensitivityHor = 34.0f;
    public float sensitivityVert = 9.0f;

    public float minmumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;

    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(axes);
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minmumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else if (axes == RotationAxes.MouseXAndY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minmumVert, maximumVert);

            float rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityHor;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
}
