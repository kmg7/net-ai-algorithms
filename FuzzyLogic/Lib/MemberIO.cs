namespace Lib
{
    internal class MemberIO
    {
        public string Name { get; set; }

        public int[] FuzzyMembers { get; set; }

        public int[] Members { get; set; }

        public MemberIO(string name, int fuzzyMembers, int members)
        {
            Name = name;
            FuzzyMembers = new int[fuzzyMembers];
            for (int i = 0; i < fuzzyMembers; i++)
            {
                FuzzyMembers[i] = i + 1;
            }

            Members = new int[members + 1];
            for (int i = 0; i <= members; i++)
            {
                Members[i] = i;
            }

        }
        public MemberIO(string name, int[] fuzzyMembers, int[] members)
        {
            Name = name;
            FuzzyMembers = fuzzyMembers;
            Members = members;
        }
    }
}
