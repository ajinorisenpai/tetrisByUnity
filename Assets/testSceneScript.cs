using DefaultNamespace;
using UnityEngine;
public class testSceneScript : MonoBehaviour
{
    [SerializeField] private ProjectManager _projectManager;
    [SerializeField] private EmproeeManager _emproeeManager;
    void Start()
    {
        _emproeeManager.Initialize();
        _projectManager.SetRandomProject();
    }
}
