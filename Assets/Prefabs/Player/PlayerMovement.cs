using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 25f;
    public Vector3 startingDirection = Vector3.right;

    Rigidbody playerBody;
    Vector3 currentDirection;


    void Awake() {
        playerBody = GetComponent<Rigidbody>();
        playerBody.freezeRotation = true;
        currentDirection = startingDirection;
    }


    void Update() {
        UpdateDirection();
        Move();
    }

    private void Move() {
        var movement = currentDirection * speed * Time.deltaTime;
        playerBody.MovePosition(playerBody.transform.position + movement);
    }
  
    private void UpdateDirection() {
        if (isChangingDirection(KeyCode.W, Vector3.forward)) {
            currentDirection = Vector3.forward;
        } else if (isChangingDirection(KeyCode.A, Vector3.left)) {
            currentDirection = Vector3.left;
        } else if (isChangingDirection(KeyCode.S, Vector3.back)) {
            currentDirection = Vector3.back;
        } else if (isChangingDirection(KeyCode.D, Vector3.right)) {
            currentDirection = Vector3.right;
        }
    }

    private bool isChangingDirection(KeyCode key, Vector3 direction) {
        return (Input.GetKeyDown(key) && currentDirection != direction);
    }
}
