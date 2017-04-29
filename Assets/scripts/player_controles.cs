using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controles : MonoBehaviour {
    private Rigidbody2D _rigidbody;
    public float Speed;
    public Borders _borders;
    public GameObject Shot;
    public Transform SpawnShotPoint;
    public float fireRate;
    private float nextFire;
   
	// Use this for initialization
	void Start () {
        _rigidbody = GetComponent<Rigidbody2D>();	
	}
    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shot, new Vector3(SpawnShotPoint.position.x, SpawnShotPoint.position.y, 0),Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical, 0f);
        transform.position += direction * Speed * Time.deltaTime;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, _borders.minx, _borders.maxx),
            Mathf.Clamp(transform.position.y, _borders.miny, _borders.maxy),
            transform.position.z);
     
    }
   [System.Serializable]
    public class Borders
    {
        public float miny, maxy, minx, maxx;
    }
}
