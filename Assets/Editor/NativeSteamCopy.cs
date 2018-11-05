using UnityEditor;
using UnityEditor.Callbacks;
/// <summary>
/// This copies over the correct native dll in the ROOT of your ASSETS folder.
/// NOT the one from plugins/native!
/// </summary>
public class NativeSteamCopy {

    [PostProcessBuild(1)]
    public static void Copy(BuildTarget target, string pathToBuiltProject) {
        if (!target.ToString().StartsWith("Standalone"))
            return;

        string dll = "steam_api.dll";
        switch (target) {
            case BuildTarget.StandaloneWindows:
                dll = "steam_api.dll";
                break;

            case BuildTarget.StandaloneWindows64:
                dll = "steam_api64.dll";
                break;

            case BuildTarget.StandaloneLinux64:
                dll = "libsteam_api64.so";
                break;

            case BuildTarget.StandaloneOSXUniversal:
                dll = "libsteam_api.dylib";
                break;

            case BuildTarget.StandaloneLinux:
                dll = "libsteam_api.so";
                break;

            default:
                UnityEngine.Debug.LogError("Couldn't find a suitable platform to copy Steam DLLs. Returning.");
                return;
        }

        FileUtil.ReplaceFile(dll, System.IO.Path.GetDirectoryName(pathToBuiltProject) + "/" + dll);
    }
}