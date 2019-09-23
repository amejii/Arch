using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Map の情報を読み込む
        // 対応する MapComponent を作成/管理する
    }

    // Update is called once per frame
    void Update()
    {
        // もし階段を降りたり、Dungeon がクリアされたり、死んで別の Field に飛ばされる時は
        // きっとここで判断して Map 情報の再読み込みとか入るんだろうなぁ...
    }
}
