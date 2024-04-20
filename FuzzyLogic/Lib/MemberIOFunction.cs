namespace Lib
{
    internal class MemberIOFunction
    {
        public MemberIO Member { get; set; }

        public FunctionType FunctionType { get; set; }
        public int[] Values { get; set; }

        public MemberIOFunction(MemberIO member, int[] values, FunctionType functionType)
        {
            // Error handling is still under consideration
            Member = member;
            Values = values;
            FunctionType = functionType;
        }
    }
}
