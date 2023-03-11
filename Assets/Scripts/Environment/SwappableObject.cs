using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Class representing an object that exists in both the dream and nightmare world,
 * but looks different in each. Implemented by syncing the position of two child objects
 * that can have different hitboxes and other properties
 */
public class SwappableObject : MonoBehaviour {
    [SerializeField] private Transform dreamObject;
    [SerializeField] private Transform nightmareObject;
    
    private Vector3 lastPosition; // last position when both objects were at the same spot

    void Start() {
        lastPosition = dreamObject.transform.position;
        nightmareObject.position = lastPosition;
    }
    void Update() {
        if (dreamObject.position != lastPosition) {
            lastPosition = dreamObject.position;
            nightmareObject.position = lastPosition;
        } else if (nightmareObject.position != lastPosition) {
            lastPosition = nightmareObject.position;
            dreamObject.position = lastPosition;
        }
    }
}
