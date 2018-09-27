# ROSBridgeSharp
This library is "ROSBridgeClient"  for Unity.

# how to use.

## 第1章 : ROSConnectorの作成

1. Unityで新規プロジェクトを作成します。
2. このリポジトリをAssetフォルダにcloneします。
```
git clone git@github.com:AtsushiSaito/ROSBridgeSharp.git
```
2. Creat Emptyで`ROSConnector`という名前のオブジェクトを作成します。
3. 作成した`ROSConnector`にAdd Componentで新規のスクリプト`ROSConnector.cs`を作成します。
4. `ROSConnector.cs`の中身を以下のように編集します。

```
using UnityEngine;
using ROSBridgeSharp;

namespace ROSBridgeSharp{
    public class ROSConnector : MonoBehaviour
    {
        public RBSocket RBS = new RBSocket();

        // ROSMasterが起動 & ROSBridgeが立ち上がっている端末のIPアドレス
        public string IPAddress = "192.168.3.40";
        // 同じくポート番号
        public string Port = "9000";

        void Start(){
            RBS.IPAddress = IPAddress;
            RBS.Port = Port;

            // WebSocketで接続
            RBS.ConnectionStart();
        }

        void Update(){
            // 接続が出来たら更新処理開始
            if (RBS.isConnected){
                RBS.Update();
            }
        }
    }
}
```
5. ROSが動いているデバイス側でROSBridgeを立ち上げて、待機状態にします。

## 第2章 : 接続テスト
1. IPアドレスやポートが正しく設定されていることを確認して、UnityのEditor上`Play`を押します。
2. 設定が合っていれば、Consoleに`WebSocket Opened.`というログが表示されます。
	* 接続が出来ない場合、`WebSocket Closed.`というログだけ表示されます。
3. `Play`を終了すると`WebSocket Closed.`というログが出てきます。

## 第3章 : 基本となるサブスクライバのクラスを書いてみよう。
1. サブスクライバを書く前に、汎用的なサブスクライバの抽象クラスを作成しておきます。
2. Aseetフォルダに新規で`BaseSubscriber.cs`というスクリプトを作成し、以下のように編集します。
```
using ROSBridgeSharp.Messages;
using UnityEngine;

namespace ROSBridgeSharp{
    [RequireComponent(typeof(ROSConnector))]
    public abstract class BaseSubscriber<T> : MonoBehaviour where T : Message
    {
        protected abstract void ReceiveHandler(T message);
        protected bool isReceived;  // メッセージを受信したかどうか。
        public string Topic;  // トピック名

        protected virtual void Start(){
            // 起動時にサブスクライバを登録
            GetComponent<ROSConnector>().RBS.AddSubscribe<T>(Topic, ReceiveHandler);
        }

        internal void RemoteStart(){
            // 外部からサブスクライバの登録用の関数
            GetComponent<ROSConnector>().RBS.AddSubscribe<T>(Topic, ReceiveHandler);
        }
    }
}
```
3. このクラスは、すべてのサブスクライバクラスに継承されるので、全体を通して必要な変数や関数がある場合は、ここに追記していくと良いでしょう。

## 第4章 : ロボットの速度を取得するサブスクライバを書く。
1. 今回は、ROSで1番使うと思われる`Twist`のサブスクライバを書いてみたいと思います。
2. `Twist型`のメッセージクラスは常にライブラリに付属させているので、手動で定義する必要はありません。
3. しかし、今後自分でメッセージクラスを定義したいときに困るので、軽く説明していきます。

## 第5章 : Twsitを構成するVector3
```
namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Vector3 : Message
    {
        public float x;
        public float y;
        public float z;
    }
}
```
1. `Twist`クラスは並進速度`linear`と角速度`angular`をVector3で定義しています。
2. メッセージクラスを作成する際は、事前に基本となるクラスをどんどん追加していく流れになります。

## 第6章 : メッセージクラスを作る上で必要なこと
1. 名前空間は`namespace ROSBridgeSharp.Messages`
2. クラス定義の上に`[System.Serializable]`を追加(JSONのパース処理で必要になる)。
3. `Message`クラスを継承する。
4. 変数は`public`で定義。

## 第7章 : Twistクラス
```
namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Twist : Message
    {
        public Vector3 linear;
        public Vector3 angular;
    }
}
```
1. 先程のVector3を元に、`linear`,`angular`を定義しています。

## 第8章 : Twistのサブスクライバを作成してみる。
1. 第1章で作成した`ROSConnector`にAdd Componentで新規のスクリプト`TwistSubscriber.cs`を作成します。

```
using UnityEngine;
using ROSBridgeSharp.Messages;

namespace ROSBridgeSharp
{
    public class TwistSubscriber : BaseSubscriber<Twist>
    {
        Twist data;

        protected override void Start(){
            base.Start();
        }

        protected override void ReceiveHandler(Twist message){
            data = message;
            isReceived = true;
        }

        internal void Update(){
            if (isReceived){
                Debug.Log(data.linear.x); // 並進速度のx方向の速度をログに表示
            }
        }
    }
}
```
2. `ROSConnector`を選択して、`Inspector`の`Twist Subscriber`の`Topic`にトピック名を入力します(例: /cmd_vel)

## 第9章 : Twistサブスクライバの動作チェック
1. `Play`で実行すると、Consoleに並進速度`linear.x`の値が出力されると思います。

## 追記中...