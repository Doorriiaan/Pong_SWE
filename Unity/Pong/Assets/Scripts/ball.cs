using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed = 10;
    //public GameObject obj_ball;
    private Camera cam;
    public Vector2 dir = new Vector2(-0.01f,0.06f);
    Scenemanager menu = new Scenemanager();
    public GameObject obj_bar;

    public HealthSystem _HealthSystem;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        Debug.Log(Screen.height);
        dir = new Vector2(Random.Range(-1f,1f),Random.Range(-1f,1f));
    }

    // Update is called once per frame
    void Update()
    { // alles rein was zy verändern ist
        
        var movement = dir * speed;

        movement *= Time.deltaTime;
        transform.Translate(movement);
        //Check for 
        if(cam.WorldToScreenPoint(transform.position).y >= Screen.height)
        {
            dir.y *= -1;
        }

        if (cam.WorldToScreenPoint(transform.position).x >= Screen.width)
        {
            dir.x *= -1;
        }
        if (cam.WorldToScreenPoint(transform.position).x <= 0)
        {
            dir.x *= -1;
        }
    
        if (cam.WorldToScreenPoint(transform.position).y <= 0)
        {
            if (_HealthSystem.AddDeath())
            {
                transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                menu.OpenMain();
            }
        }

    }
    /// <summary>
    /// Checking for Collision with a GameObject tagged as "Player". If it collides, the direction of the Ball gets inverted
    /// </summary>
    /// <param name="coll"></param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player") { // bei jeder Beruehrung aufgerufen, aber nur wenn tag player ist
            Debug.Log("Enter");
            dir.y *= -1;
            //Modify rebound angles
            /*
            if (obj_ball.transform.position.x < obj_bar.transform.position.x - 0.5f)
            {
                dir.x -=0.002f;
            }
            else if (obj_ball.transform.position.x < obj_bar.transform.position.x + 0.5f)
            {
                dir.x += 0.002f;
            }
            */


        }
    }

}
