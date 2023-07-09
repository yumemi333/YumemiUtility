using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Control where to back
/// </summary>
public class BackButton : MonoBehaviour
{

    /// <summary>
    /// cash previous scenes
    /// </summary>
    private static Stack<string> prevScenes = new Stack<string>();


    /// <summary>
    /// set scenes which are not under control by this class
    /// </summary>
    private static readonly List<string> IgnoreScenes = new List<string>() { "Game" };

    /// <summary>
    /// base scene * this is used in case you don have cashed scene to back.
    /// </summary>
    static readonly string BaseScene = "Title";

    public void BackScene()
    {
        prevScenes.Pop();
        Stack<string> tmp = new Stack<string>(prevScenes.Reverse());
        
        foreach (var item in prevScenes)
        {
            if (SceneManager.GetActiveScene().name == prevScenes.Peek())
            {
                tmp.Pop();
            }
            else
            {
                break;
            }
        }
        prevScenes = new Stack<string>(tmp.Reverse());

        if (prevScenes.Count > 0)
            SceneChange.FadeInOut(prevScenes.Peek());
        else
            SceneChange.FadeInOut(BaseScene);
    }

    /// <summary>
    /// call this when change scene!!
    /// </summary>
    /// <param name="scene"></param>
    public static void ChangeScene(string scene)
    {
        // Ensure that there is no trace of going back and forth on the stack when going back and forth between the same scene.
        if (prevScenes.Contains(scene))
            return;
        foreach (var item in IgnoreScenes)
        {
            if (item == scene)
                return;
        }

        prevScenes.Push(scene);
    }


    /// <summary>
    /// Initialize the stack.
    /// </summary>
    public static void StackReset()
    {
        prevScenes.Clear();
        prevScenes.Push(BaseScene);
    }
}
