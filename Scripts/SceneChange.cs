using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class SceneChange : MonoBehaviour
{
    public void Cantina_Scene()
    {
        SceneManager.LoadScene("Cantina");
    }
    public void LivingRoom_Scene()
    {
        SceneManager.LoadScene("LivingRoom");
    }
    public void Cube_Scene()
    {
        SceneManager.LoadScene("Cube");
    }
}
