using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToTitle : MonoBehaviour
{
    public void GoTitle()
    {
        SceneManager.LoadScene(3);
    }
}
