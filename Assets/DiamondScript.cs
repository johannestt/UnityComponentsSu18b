using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    [Range(0, 720)]
    public float rotationspeed;
    public SpriteRenderer rend;
    public Color newColor;
    public Transform trans;

    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(1f, 0.5f, 32f);
        // trans.position = new Vector3(3, 2, trans.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationspeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0, Space.World);
        }


    }
}
