# YumemiUtility
ちょっとした便利なスクリプトをまとめていく

## BackButton.cs
To use, call BackButton.ChangeScene(string scene) when transitioning scenes.
BackButton is added to each back button component, and BackScene() is called when the button is pressed.

使い方としては、シーンを遷移するときにBackButton.ChangeScene(string scene)を呼出す。
BackButtonは各戻るボタンのcomponentに追加し、ボタンが押されたときに BackScene()を呼び出す。

## DateTimeUtili.cs 
By setting specific culture info when use DateTime, prevent erorr that is possibile to be caused by such as different calendar settings (ex thai calendar).

DateTimeを使用する際に特定のカルチャ情報を設定することで、異なるカレンダーの設定（例えばタイのカレンダー）などによって起こりうるエラーを防ぐことができます。

## TimeCounter.cs
You can set left time with free format as you want ! for example HH:mm:ss or mm:ss… 

自由なフォーマットで残り時間を設定できます
