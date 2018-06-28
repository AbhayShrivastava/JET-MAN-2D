using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {
        public float Jspeed;
    private Rigidbody2D rb;
    private Animator anim;
    public uiManager UI;

    private AudioSource am;

    void Awake()
    {
        am = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();

    }

	// Use this for initialization
	void Start () {
       
        anim = GetComponent<Animator>();
        
      
	}
	
	// Update is called once per frame
    void Update()
    {  
        Touchmove();
       

           

            
      
    }
    void Touchmove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
             Time.timeScale = 1;
                rb.velocity = new Vector2(0, Jspeed);
                am.Play();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject)
        {  anim.SetBool("die", true);
      
            UI.GameOverActivated();
            rb.velocity = Vector2.zero;
            am.Stop();
          

        }
    
    
    }
      
      
}
