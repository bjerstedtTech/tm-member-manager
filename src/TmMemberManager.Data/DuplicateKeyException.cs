using System;

namespace TmMemberManager.Data
{
    public class DuplicateKeyException : Exception
    {
        public DuplicateKeyException(string keyName, string @class)
            : base($"Duplicate Key: {keyName} for {@class}")
        {
            KeyName = KeyName;
            Class = @class;
        }

        public string KeyName { get; }
        public string Class { get; }
    }
}
