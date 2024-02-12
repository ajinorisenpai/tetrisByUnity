using DefaultNamespace.ProjectData;
using UnityEngine;

namespace DefaultNamespace
{
    public class ProjectManager : MonoBehaviour
    {
        [SerializeField] private ProjectDataSettings _projectDataSetting;
        [SerializeField] private ProjectView _projectView;


        public void SetRandomProject()
        {
            var project = _projectDataSetting.DataList[Random.Range(0, _projectDataSetting.DataList.Length)];
            UpdateView(project);
        }
        
        void UpdateView(ProjectData.ProjectData card)
        {
            _projectView.UpdateLabel(card);
        }
    }
}