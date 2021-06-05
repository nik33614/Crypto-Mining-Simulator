using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int Level;

    public void ChangeLevel()
    {
        SceneManager.LoadScene(Level);
    }

}
