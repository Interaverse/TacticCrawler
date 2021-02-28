using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : SubBattle
{
    SubBattle battle = new SubBattle();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (battle.BattleMode == true)
        {
            BattleMode();
            Debug.Log("battleMOde is now");
        }
    }
    void BattleMode()
    {
        this.GetComponent<AudioSource>().Pause();
        this.GetComponent<AudioSource>().clip = battle.attackClip;
        this.GetComponent<AudioSource>().Play();
    }
}
