using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour {
    Renderer rend;
    void Awake () {
        rend = GetComponent<Renderer>();
        SetColor(Color.cyan);
    }
    public void SetColor(Color color) {
        rend.material.color = color;
    }
}
