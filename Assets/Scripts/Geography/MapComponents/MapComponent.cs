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

    void OnCollisionStay(Collision other) {
        if (other.gameObject.CompareTag("CharacterObject")) {
            ProcessStayingCharacter(other.gameObject.GetComponent<CharacterComponent>());
        } else if (other.gameObject.CompareTag("ItemObject")) {
            ProcessStayingItem(other.gameObject.GetComponent<ItemComponent>());
        }
    }

    public abstract void ProcessEnteringCharacter(CharacterComponent character);
    public abstract void ProcessEnteringItem(ItemComponent item);

    public abstract void ProcessStayingCharacter(CharacterComponent character);
    public abstract void ProcessStayingItem(ItemComponent item);
}