namespace Builder.Interfaces
{
    internal interface ISqlQueryBuilder
    {
        public ISqlQueryBuilder Select(string table, string[] fields);

        public ISqlQueryBuilder Where(string field, string value, string operation = "=");

        public ISqlQueryBuilder Operator(string operation);

        public void Reset();

        // ... other methods

        public string GetSQL();
    }
}
