namespace DefaultNamespace
{
    public class EmployeeData
    {
        public int Cost;
        public int Skill;
        public int Mental;
        public string Name;

        public EmployeeData(string name,int cost, int skill, int mental)
        {
            Name = name;
            Cost = cost;
            Skill = skill;
            Mental = mental;
        }
    }
}