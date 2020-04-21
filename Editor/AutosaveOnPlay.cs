using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace Editor
{
    [InitializeOnLoad]
    public class AutosaveOnPlay
    {
        static AutosaveOnPlay()
        {
            EditorApplication.playModeStateChanged += SaveOnPlay;
        }

        private static void SaveOnPlay(PlayModeStateChange state)
        {
            if (state != PlayModeStateChange.ExitingEditMode)
                return;
            
            Debug.LogWarning("Auto-saving...");
            EditorSceneManager.SaveOpenScenes();
            AssetDatabase.SaveAssets();
        }
    }
}
