using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class ProjectView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI projectName;
        [SerializeField] private TextMeshProUGUI needSkill;
        [SerializeField] private TextMeshProUGUI getSkill;
        [SerializeField] private TextMeshProUGUI needEmployeeTime;

        public void UpdateLabel(ProjectData.ProjectData projectCard)
        {
            projectName.text = projectCard.Name;
            needEmployeeTime.text = $"所要工数: {projectCard.Cost}人月";
            needSkill.text = $"必要能力: スキル{projectCard.Skill}";
            getSkill.text = $"習得スキル: スキル{projectCard.GetSkill}, メンタル{projectCard.LostMental*-1}";
        }
    }
}