using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    private SubBattle mainBattle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("EngageBattle"))
        {
            mainBattle = GameObject.Find("EngageBattle").GetComponent<SubBattle>();
            if (mainBattle.BattleMode == true)
            {
                BattleMode();
            }
        }
    }
    void BattleMode()
    {

        this.GetComponent<AudioSource>().Pause();
        this.GetComponent<AudioSource>().clip = mainBattle.attackClip;
        this.GetComponent<AudioSource>().Play();
    }
}
