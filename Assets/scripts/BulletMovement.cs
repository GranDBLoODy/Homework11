using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    private Rigidbody _rb;
    public float Speed;

    // Use this for initialization
    void Start () {
        _rb = GetComponent<Rigidbody>();
        _rb.velocity = transform.forward * Speed;
        gameObject.GetComponent<Rigidbody>().velocity =gameObject.transform.forward * Speed;
        Destroy(gameObject, 3.0f);

    }

    // Update is called once per frame
    void Update() {
    }
}
