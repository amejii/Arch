using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonMap : MonoBehaviour
{
    private const int MAP_HEIGHT = 8;
    private const int MAP_WIDTH = 8;
    private const float MAP_OBJECT_HEIGHT = 1;
    private const float MAP_OBJECT_WIDTH = 1;
    [SerializeField]
    private GameObject NormalGroundObject;
    [SerializeField]
    private GameObject PoisonSwampObject;
    [SerializeField]
    private GameObject NormalWallObject;

    private GameObject[,] dungeonMap = new GameObject[MAP_HEIGHT,MAP_WIDTH];

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Map の情報を読み込む
        // 対応する MapComponent を作成/管理する
        for (int i = 0; i < MAP_HEIGHT; i++) {
            for (int j = 0; j < MAP_WIDTH; j++) {
                // 壁の生成箇所は部屋の周り
                if (i == 0 || i == MAP_HEIGHT - 1 || j == 0 || j == MAP_WIDTH - 1)
                {
                    dungeonMap[i, j] = Instantiate(NormalWallObject,
                        new Vector3(i*MAP_OBJECT_HEIGHT, 0.0f, j*MAP_OBJECT_WIDTH),
                        Quaternion.Euler(90.0f, 0.0f, 0.0f));
                }
                // 毒沼の生成箇所は中央
                else if (i == MAP_HEIGHT / 2 && j == MAP_WIDTH / 2) 
                {
                    Debug.Log("毒沼");
                    dungeonMap[i, j] = Instantiate(PoisonSwampObject,
                        new Vector3(i*MAP_OBJECT_HEIGHT, 0.0f, j*MAP_OBJECT_WIDTH),
                        Quaternion.Euler(90.0f, 0.0f, 0.0f));
                }
                // その他は単なる何の変哲もない地面です
                else {
                    Debug.Log("地面");
                    dungeonMap[i, j] = Instantiate(NormalGroundObject,
                        new Vector3(i*MAP_OBJECT_HEIGHT, 0.0f, j*MAP_OBJECT_WIDTH),
                        Quaternion.Euler(90.0f, 0.0f, 0.0f));
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // もし階段を降りたり、Dungeon がクリアされたり、死んで別の Field に飛ばされる時は
        // きっとここで判断して Map 情報の再読み込みとか入るんだろうなぁ...
    }
}
