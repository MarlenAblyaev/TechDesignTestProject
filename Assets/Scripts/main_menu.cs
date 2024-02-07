using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    [SerializeField] private GameObject _scene_button;

    public void Switch_Scene_Button()
    {
        _scene_button.SetActive(!_scene_button.activeSelf);
    }

    public void Load_Scene(int id)
    {
        SceneManager.LoadScene(id, LoadSceneMode.Single);
    }
}
