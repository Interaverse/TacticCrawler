using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dungeon1 : MonoBehaviour
{
    private float max = 20;
    private float count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count < max)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.05f);
            count += 0.05f;
        }

    }
}
