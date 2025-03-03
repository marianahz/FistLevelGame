using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
  public Transform target;
public float smoothSpeed = 0.125f;
public Vector3 offSet;

private void LateUpdate()
{

    Vector3 desiredPosition = target.position + offSet;
    Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    transform.position = smoothPosition;
}
}
