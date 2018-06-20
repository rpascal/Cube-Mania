using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedGround : BaseGround {

    protected override void CollisionPlayerProperties(PlayerProperties playerProperties) {
        playerProperties.SetColor(Color.black);
    }
 
}
