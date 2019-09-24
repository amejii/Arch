using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComponent : MonoBehaviour
{
    // Character の状態 (毒とか睡眠とか空腹とかとかえとせとら)
    public HashSet<CharacterState> CharacterStates { get; set; }

    // Character の特性 (毒無効とか自動回復とかとかえとせとら)
    public HashSet<CharacterCharacteristic> CharacterCharacteristics { get; set; }

    // Turn が回ってきた際に自分が立っている場所の MapComponent
    public MapComponent Ground { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
