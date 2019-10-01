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
        CatchPlayerInput();
    }

    void CatchPlayerInput(){
        if(isMoveFinished){
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            var moveAmount = Vector3.zero;
            if(horizontal<0){
                moveAmount.x = -1.0f;
            }else if(horizontal>0){
                moveAmount.x = 1.0f;
            }
            if(vertical<0){
                moveAmount.z = -1.0f;
            }else if(vertical>0){
                moveAmount.z = 1.0f;
            }
            var newPosition = this.transform.position + moveAmount;
            //Debug.Log(newPosition);
            StartCoroutine(CharacterMovement(newPosition));
        }   
    }
}
