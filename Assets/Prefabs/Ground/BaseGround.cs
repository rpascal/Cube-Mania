using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGround : MonoBehaviour {
    protected abstract void CollisionPlayerProperties(PlayerProperties playerProperties);

    private void OnCollisionEnter(Collision collision) {
        var playerProperties = collision.collider.GetComponent<PlayerProperties>();
        if (playerProperties) {
            CollisionPlayerProperties(playerProperties);
        }
    }

}
