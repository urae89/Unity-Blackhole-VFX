using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class CameraControl : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private Transform target;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }


    // Update is called once per frame
    void Update()
    {
        cam.nearClipPlane = Vector3.Distance(transform.position, target.position);
    }
}
