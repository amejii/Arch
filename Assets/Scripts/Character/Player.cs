using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : CharacterComponent
{
    private long frame;

    // Start is called before the first frame update
    void Start()
    {
        frame = 0;
        CharacterStates = new HashSet<CharacterState>();
        CharacterCharacteristics = new HashSet<CharacterCharacteristic>();
        // CharacterCharacteristics.Add(CharacterCharacteristic.PoisonGuard);
    }

    // Update is called once per frame
    void Update()
    {
        frame = frame++ % 100000000000;
        if (frame == 0) {
            string statesLog = "";
            foreach (CharacterState s in CharacterStates)
            {
                statesLog += s.ToString() + ", ";
            }
            Debug.Log("Player States: " + statesLog);

            string characteristicsLog = "";
            foreach (CharacterCharacteristic c in CharacterCharacteristics)
            {
                characteristicsLog += c.ToString() + ", ";
            }
            Debug.Log("Player Characteristics: " + characteristicsLog);
        }
    }

}
