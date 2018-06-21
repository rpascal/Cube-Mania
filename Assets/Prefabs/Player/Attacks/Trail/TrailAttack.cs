using System.Collections;
using System.Collections.Generic;
using Ara;
using UnityEngine;

public class TrailAttack : BaseAttack {

    private AraTrail trail;

    protected override void OnAttackDestroy() {

    }

    protected override void OnAttackInitialize() {
        trail = GetComponent<AraTrail>();
    }

    protected override void OnAttackUpdate() {

        if (Input.GetKey(KeyCode.Space)) {
            trail.emit = false;
        } else {
            trail.emit = true;

        }

    }

}
