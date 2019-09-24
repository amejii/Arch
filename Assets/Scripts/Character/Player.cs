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
        Ground = null;
    }

    // Update is called once per frame
    void Update()
    {
        frame = frame++ % 1000000000000000000;
        if (frame == 0 && Ground != null) {
            Ground.AffectToCharacter(this);
            string states = "";
            foreach (CharacterState s in CharacterStates)
            {
                states += s.ToString();
            }
            Debug.Log("Player State: " + states);
        }
    }

}
