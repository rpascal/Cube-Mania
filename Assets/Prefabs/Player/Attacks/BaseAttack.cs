using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAttack : MonoBehaviour {

    protected abstract void OnAttackInitialize();
    protected abstract void OnAttackDestroy();
    protected abstract void OnAttackUpdate();


    // Use this for initialization
    void Start() {
        OnAttackInitialize();
    }

    // Update is called once per frame
    void Update() {
        OnAttackUpdate();
    }

    private void OnDestroy() {
        OnAttackDestroy();
    }



}
