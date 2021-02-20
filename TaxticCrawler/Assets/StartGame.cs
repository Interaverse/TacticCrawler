using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject gate;
    public GameObject dungeon;
    public Transform connector;
    private BoxCollider2D start_game;
    // Start is called before the first frame update
    void Start()
    {
        start_game = this.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gate);
        GameObject[] excess = GameObject.FindGameObjectsWithTag("Excess");
        for (int i = 0; i < excess.Length; i++)
        {
            Destroy(excess[i]);
        }
        Instantiate(dungeon, new Vector3(connector.transform.position.x,connector.transform.position.y - 20,connector.transform.position.z), Quaternion.identity);
        Destroy(start_game);
    }
}
