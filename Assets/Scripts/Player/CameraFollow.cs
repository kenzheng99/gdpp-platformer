using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private GameObject objectToFollow;
    [SerializeField] private Vector3 offset;

    void Update() {
        gameObject.transform.position = objectToFollow.transform.position + offset;
    }
}