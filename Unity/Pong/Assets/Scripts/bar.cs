using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class bar : MonoBehaviour
{
    public GameObject obj_bar;
    public float width;
    public Sprite skin;
    public Rect rect;
    public Sprite barTransform;
    public float position_x;
    private float _width;
    private float _height;
    private Camera cam;
    [FormerlySerializedAs("barSpeed")] public float speed = 5f;
    private float movement;

    private Vector3 position;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        Vector3 point;

        // Update the Text on the screen depending on current position of the touch each frame
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            point = cam.ScreenToWorldPoint(touch.position);
            if (Math.Abs(point.x - obj_bar.transform.position.x) >= 0.2)
            {
                if (point.x < obj_bar.transform.position.x)
                {
                    Debug.Log("left");
                    movement = -1 * speed;
                    //Generates an FPS independent movementspeed 
                    movement *= Time.deltaTime;
                }
                else
                {
                    Debug.Log("right");
                    movement = 1 * speed;
                    //Generates an FPS independent movementspeed 
                    movement *= Time.deltaTime;
                }
                //ToDo check, if Bar hits the Screen end, if so, dont move the Bar any more
                obj_bar.transform.Translate(movement,0, 0);
            }
            //obj_bar.transform.position = new Vector3(point.x, obj_bar.transform.position.y, -1);
        }
    }

    void moveLeft()
    {
        obj_bar.transform.Translate(-speed,0, 0);
    }

    void moveRight()
    {
        obj_bar.transform.Translate(speed,0, 0);
    }
   
}
