using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class EmployeeCard : MonoBehaviour
    {
        private Button assignButton;
        [SerializeField] private TextMeshProUGUI nameLabel;
        [SerializeField] private TextMeshProUGUI costLabel;
        [SerializeField] private TextMeshProUGUI skillLabel;
        [SerializeField] private TextMeshProUGUI mentalLabel;
        private EmployeeData _employeeData;
        
        public void SetEmproeeCard(EmployeeData employeeData)
        {
            this._employeeData = employeeData;
            UpdateLabel(employeeData);
        }

        public void SetSkill(int value)
        {
            this._employeeData.Skill = value;
            UpdateLabel(_employeeData);
        }

        public void SetMental(int value)
        {
            this._employeeData.Mental = value;
            UpdateLabel(_employeeData);
        }

        private void UpdateLabel(EmployeeData employeeData)
        {
            nameLabel.text = employeeData.Name;
            costLabel.text =  employeeData.Cost+ "万/月";
            skillLabel.text = "スキル: " + employeeData.Skill;
            mentalLabel.text = "メンタル: " + employeeData.Mental;
        }
    }
}