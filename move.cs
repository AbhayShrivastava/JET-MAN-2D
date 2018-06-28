using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    private Rigidbody2D rb2D;
    public float speed;
   

	// Use this for initialization


   
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = new Vector2(-speed, 0);
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}


   
           

        
        
        
        }

    

