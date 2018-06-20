using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGround : BaseGround {

    protected override void CollisionPlayerProperties(PlayerProperties playerProperties) {
        playerProperties.SetColor(Color.red);
    }

}
