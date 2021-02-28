using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBattle : MonoBehaviour
{
    public AudioClip attackClip;
    public bool BattleMode = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        col.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        BattleMode = true;
    }
}
