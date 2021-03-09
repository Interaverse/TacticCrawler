using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject gate;
    public GameObject dungeon;
    public Transform connector;
    private BoxCollider2D start_game;
    public GameObject mainCharacter;
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
        mainCharacter.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, mainCharacter.transform.position.z);
        mainCharacter.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        Destroy(gate);
        GameObject[] excess = GameObject.FindGameObjectsWithTag("Excess");
        for (int i = 0; i < excess.Length; i++)
        {
            Destroy(excess[i]);
        }
        Instantiate(dungeon, new Vector3(connector.transform.position.x,connector.transform.position.y - 20,5), Quaternion.identity);
        StartCoroutine(WaitForBridge());
    }
    IEnumerator WaitForBridge()
    {
        //Print the time of when the function is first called.
        

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(2);

        //After we have waited 5 seconds print the time again.
        mainCharacter.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        Destroy(start_game);
    }
}
