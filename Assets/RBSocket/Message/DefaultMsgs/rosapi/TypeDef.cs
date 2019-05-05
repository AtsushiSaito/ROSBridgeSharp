using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class TypeDef : ExtendMessage
    {
        public string type;
        public string[] fieldnames;
        public string[] fieldtypes;
        public int[] fieldarraylen;
        public string[] examples;
        public override string Type() { return "rosapi/TypeDef"; }
        public TypeDef()
        {
            type = "";
            fieldnames = new string[0];
            fieldtypes = new string[0];
            fieldarraylen = new int[0];
            examples = new string[0];
        }
    }
}