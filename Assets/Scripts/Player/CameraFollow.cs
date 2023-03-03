using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private GameObject objectToFollow;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float followSpeed;

    void FixedUpdate() {
        Vector3 targetPosition = objectToFollow.transform.position + offset;
        float distance = (targetPosition - transform.position).magnitude;
        Vector3 newPosition = Vector3.MoveTowards(transform.position, targetPosition, followSpeed * distance * Time.fixedDeltaTime);
        transform.position = newPosition;
    }
}