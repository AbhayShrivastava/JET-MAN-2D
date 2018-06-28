using UnityEngine;
using System.Collections;

public class Backgroundmove : MonoBehaviour {
    float speed=5f;


    private Rigidbody2D rb2D;
    private BoxCollider2D groundCollider;
    private float GroundHorizontalLength;
    

    
	// Use this for initialization
    void Start () {
	rb2D=GetComponent<Rigidbody2D>();
    rb2D.velocity=new Vector2(-speed,0);
    groundCollider = GetComponent<BoxCollider2D>();
    GroundHorizontalLength = groundCollider.size.x + 4.88049f;

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x< -GroundHorizontalLength)
        {
            Repostion();
        }

	}

    private void Repostion()
    
    { 
        Vector2 groundOffset=new Vector2(GroundHorizontalLength*2f,0);
        transform.position=(Vector2)transform.position + groundOffset;


    }
}
