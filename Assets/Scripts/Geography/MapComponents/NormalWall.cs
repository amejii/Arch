using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalWall : MapComponent
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
        Debug.Log("Character: " + character.GetInstanceID().ToString() + " is entering on normal wall (" + this.GetInstanceID().ToString());
    }
    public override void ProcessEnteringItem(
        ItemComponent item)
    {
        Debug.Log("Item : " + item.GetInstanceID().ToString() + " is entering on normal wall (" + this.GetInstanceID().ToString() + ").");
    }

    public override void ProcessStayingCharacter(
        CharacterComponent character)
    {
        Debug.Log("Character : " + character.GetInstanceID().ToString() + " is staying on normal wall (" + this.GetInstanceID().ToString() + ").");
    }
    public override void ProcessStayingItem(
        ItemComponent item)
    {
        Debug.Log("Item : " + item.GetInstanceID().ToString() + " is staying on normal wall (" + this.GetInstanceID().ToString() + ").");
    }
}