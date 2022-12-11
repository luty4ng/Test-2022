using UnityEditor;
using UnityEditor.SceneManagement;
public static class ScenesList
{
        [MenuItem("Scenes/Default")]
        public static void Assets_GameMain_Scenes_Default_unity() { ScenesUpdate.OpenScene("Assets/GameMain/Scenes/Default.unity"); }
        [MenuItem("Scenes/Launcher")]
        public static void Assets_Kit_Launcher_unity() { ScenesUpdate.OpenScene("Assets/Kit/Launcher.unity"); }
        [MenuItem("Scenes/Conditional Graph")]
        public static void Assets_Kit_Plugins_NodeGraphProcessor_Samples_Examples_Scenes_Conditional_Graph_unity() { ScenesUpdate.OpenScene("Assets/Kit/Plugins/NodeGraphProcessor/Samples/Examples/Scenes/Conditional Graph.unity"); }
        [MenuItem("Scenes/EmbeddedGraph")]
        public static void Assets_Kit_Plugins_NodeGraphProcessor_Samples_Examples_Scenes_EmbeddedGraph_unity() { ScenesUpdate.OpenScene("Assets/Kit/Plugins/NodeGraphProcessor/Samples/Examples/Scenes/EmbeddedGraph.unity"); }
        [MenuItem("Scenes/RuntimeGraph")]
        public static void Assets_Kit_Plugins_NodeGraphProcessor_Samples_Examples_Scenes_RuntimeGraph_unity() { ScenesUpdate.OpenScene("Assets/Kit/Plugins/NodeGraphProcessor/Samples/Examples/Scenes/RuntimeGraph.unity"); }
}
