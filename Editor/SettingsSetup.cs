using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class SettingsSetup : EditorWindow
{
    [MenuItem("VR/Project setup")]
    public static void ShowWindow()
    {
        GetWindow<SettingsSetup>().titleContent = new GUIContent("VR - Project setup");
    }

    public void OnEnable()
    {
        var root = rootVisualElement;
        root.Add(new Label("Enable VR settings"));
  
        var button = new Button();
        button.clickable.clicked += () =>
        {
            PlayerSettings.virtualRealitySupported = !PlayerSettings.virtualRealitySupported;
            button.text = PlayerSettings.virtualRealitySupported ? "Disable" : "Enable";
        };
        button.text = PlayerSettings.virtualRealitySupported ? "Disable" : "Enable";
        root.Add(button);
    }
}