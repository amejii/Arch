using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    void Start()
    {
        // Game Loopのための初期化処理
        // Gameに必要な初期化処理の起点がここ
        // DungeonMapを含んだ
    }

    void Update()
    {
        // Game Loop
        // 各種現状を示すFlagやDungeonMapから描画するべき状態を決める
        // - Unity使ってるし殆ど必要ないかも
        // - 階段上った判定使って料理画面に遷移する処理もいるかー
        //料理画面の場合
        // なんもわからん
        //ダンジョン画面の場合
        // 誰のターンなのかを判定
        // - 自キャラのパス
        //   - DungeonMap / Player情報 / Enemy情報を元に取れるActionとその結果が決まる
        //   - 取れるActionは以下
        //     - 移動
        //     - 通常攻撃
        //     - Itemの使用
        //   - 取れるActionの内、どれを決定するのかはKey Inputを見て決める
        //     - 移動系Key Inputのみ
        //       - 進行方向に敵及び障害物となるMapComponentが無い場合はその方向に1マスだけ移動する
        //         - 移動時にDungeonMapを更新する
        //       - 敵及び障害物がある場合は何もしなかったのと同義
        //     - 方向転換Key Input + 移動系Key Input
        //       - 移動系Key Inputに対応する方向にPlayerを向かせる
        //         - Roguelike ではたかだか8方向
        //         - 移動系Key Inputがスティックやタッチに対応している場合はFloat値の閾値を決める必要あり(知らんけど)
        //     - 通常攻撃Key Input
        //       - 向いている方向に装備している武器で攻撃を行う
        //     - メニューKey Input
        //       - メニュー画面を開く
        //         - メニュー画面でのKey Input解釈は別
        //         - アイテム項目がある
        //           - ここより先の詳細はMenu classに任せる
        //           - Menu classとGameManager class間のinterface部分をどう作るかはまだ考えてない
        // - 敵キャラのパス
        //   - DungeonMap / Player情報 / 自分以外のEnemy情報を元にActionを決める
        //   - 取れるActionは以下
        //     - 移動
        //     - 通常攻撃
        //     - Itemの使用
        // 移動した後に罠の影響を受けたり、攻撃後の色々な影響があったりするけど、それは各Action Logicで吸収してクレメンス
    }
}