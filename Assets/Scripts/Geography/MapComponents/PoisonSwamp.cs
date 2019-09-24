using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSwamp : MapComponent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ProcessEnteringCharacter(
        CharacterComponent character)
    {
        Debug.Log("Character: " + character.GetInstanceID().ToString() + " is entering on poison swamp (" + this.GetInstanceID().ToString());
        // ここで character component の ground field を更新する
        AffectToCharacter(character);
    }
    public override void ProcessEnteringItem(
        ItemComponent item)
    {
        Debug.Log("Item : " + item.GetInstanceID().ToString() + " is entering on poison swamp (" + this.GetInstanceID().ToString() + ").");
        // ここで AffectToItem を呼んでもいい
        
    }

    public override void AffectToCharacter(CharacterComponent character)
    {
        // 毒無効の特性を持っていない場合は毒状態にする
        if (!character.CharacterCharacteristics.Contains(CharacterCharacteristic.PoisonGuard))
        {
            character.CharacterStates.Add(CharacterState.Poison);
        }
    }

    public override void AffectToItem(ItemComponent item)
    {
        // そういえば水あたりの Item Component が毒沼に入ったら毒水になるとかしたい場合はどうなるんやろなぁ、、、
    }
}