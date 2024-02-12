using UnityEngine;

namespace DefaultNamespace.ProjectData
{
    [CreateAssetMenu(menuName = "ScriptableObject/ProjectData", fileName = "ProjectData")]
    public class ProjectDataSettings : ScriptableObject
    {
        public ProjectData[] DataList;
    }
}