using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    
    [SerializeField]
    float moveSpeed = -5f;
    public int a;
    public int b;
    public int c;
    public int d;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime,
            transform.position.y);

        if (transform.position.x < -13f)
            Destroy(gameObject);
        Physics2D.IgnoreLayerCollision(a, b);
        Physics2D.IgnoreLayerCollision(c, d);
    }
}
