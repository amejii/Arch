using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MapComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Unity Editor でとある GameObject に Attach される Map 用 ScriptComponent
        // Required Component に色々必要なものはありそう
    }

    // Update is called once per frame
    void Update()
    {
        // 次元付きの MapComponent とかならきっとここに色々な処理が行われるんだろうな
        // もしくは他の Component からなんらかの Message を受けて独自の処理をするのかもしれません
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("CharacterObject")) {
            ProcessEnteringCharacter(other.gameObject.GetComponent<CharacterComponent>());
        } else if (other.gameObject.CompareTag("ItemObject")) {
            ProcessEnteringItem(other.gameObject.GetComponent<ItemComponent>());
        }
    }

    public abstract void ProcessEnteringCharacter(CharacterComponent character);
    public abstract void ProcessEnteringItem(ItemComponent item);

    /// <summary> 
    /// AffectToCharacter is called by a character component and
    /// affects some side effects to the character.
    /// </summary>
    /// <param name="character">A CharacterComponent receiving these side effects.</param>
    public abstract void AffectToCharacter(CharacterComponent character);

    /// <summary> 
    /// AffectToItem is called by an item component and
    /// affects some side effects to the item.
    /// </summary>
    /// <param name="character">A ItemComponent receiving these side effects.</param>
    public abstract void AffectToItem(ItemComponent item);
}
