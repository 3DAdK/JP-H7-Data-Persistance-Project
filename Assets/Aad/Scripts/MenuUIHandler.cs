using System;
using System.Collections;
using System.Collections.Generic;

// Conditional instructions...
#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;
// SceneManagement is added to use the SceneManager....
using UnityEngine.SceneManagement;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    private void Start()
    {

    }

    // Our method to load the main scene.
    public void StartNew()
    {
        // Scenemanager is the class that handles everything related to loading and unloading scenes.
        // The number 1 is the index of the scene we want to load.
        SceneManager.LoadScene(1);
    }

    // Our method to exit the application.
    public void Exit()
    {
        // Here we are using conditional compiling to branch the code....
        #if UNITY_EDITOR
        // Run this code...
        // Editorapplication uses the namespace UnityEditor
            EditorApplication.ExitPlaymode();
        #else
        // Run this code...
        // Original code to quit Unity player.
            Application.Quit();
        #endif
    }
    
}
