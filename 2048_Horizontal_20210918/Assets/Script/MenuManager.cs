
using UnityEngine;
using UnityEngine.SceneManagement;//引用場景管理
using UnityEngine.Audio;
/// <summary>
/// Event管理器
/// </summary>
public class MenuManager : MonoBehaviour
{
    
    public AudioMixer mixer;
    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void StartGame(float delay) {
        //載入場景
        Invoke("DelayStartGame", delay);
    }

    private void DelayStartGame() {
        SceneManager.LoadScene("遊戲畫面");
    }

    /// <summary>
    /// 設定遊戲
    /// </summary>
    public void SettingGameBGM(float sound) {
        mixer.SetFloat("音量BGM", sound);
    }
    public void SetteingGameSFX(float sound) {
        mixer.SetFloat("音量SFX", sound);
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitButton(float delay) {

        Invoke("DelayQuitButton", delay);
    }
    public void DelayQuitButton() {
        Application.Quit();

        print("離開遊戲");
    }
}
