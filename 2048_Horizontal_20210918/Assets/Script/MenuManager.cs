
using UnityEngine;
using UnityEngine.SceneManagement;//�ޥγ����޲z
using UnityEngine.Audio;
/// <summary>
/// Event�޲z��
/// </summary>
public class MenuManager : MonoBehaviour
{
    
    public AudioMixer mixer;
    /// <summary>
    /// �}�l�C��
    /// </summary>
    public void StartGame(float delay) {
        //���J����
        Invoke("DelayStartGame", delay);
    }

    private void DelayStartGame() {
        SceneManager.LoadScene("�C���e��");
    }

    /// <summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGameBGM(float sound) {
        mixer.SetFloat("���qBGM", sound);
    }
    public void SetteingGameSFX(float sound) {
        mixer.SetFloat("���qSFX", sound);
    }
    /// <summary>
    /// ���}�C��
    /// </summary>
    public void QuitButton(float delay) {

        Invoke("DelayQuitButton", delay);
    }
    public void DelayQuitButton() {
        Application.Quit();

        print("���}�C��");
    }
}
