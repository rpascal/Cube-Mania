using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour {
    Renderer rend;

    BaseAttack currentAttack;

    void Awake () {
        rend = GetComponent<Renderer>();
        SetColor(Color.cyan);
    }
    public void SetColor(Color color) {
        rend.material.color = color;
    }

    public void SetAttack(BaseAttack attack) {
        if (currentAttack) {
            Destroy(currentAttack);
        }
        currentAttack = Instantiate(attack, transform.position, Quaternion.identity);
        currentAttack.transform.parent = transform;
    }

}
