using UnityEngine;

namespace DefaultNamespace
{
    public class EmproeeManager : MonoBehaviour
    {
        [SerializeField] private EmployeeCard[] _emproeeCards;
        EmployeeData[] emproeeDatas =
        {
            new EmployeeData("新人", 100, 1, 0),
            new EmployeeData("中堅", 200, 2, 0),
            new EmployeeData("ベテラン", 300, 3, 0)
        };
        public void Initialize()
        {
            for (int i = 0; i < _emproeeCards.Length; i++)
            {
                _emproeeCards[i].SetEmproeeCard(emproeeDatas[i/2]);
            }
        }
    }
}