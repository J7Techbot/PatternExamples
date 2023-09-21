using Builder.Interfaces;

namespace Builder.Builders
{
    internal class MsSqlQueryBuilder : ISqlQueryBuilder
    {
        private string _sql;

        public ISqlQueryBuilder Operator(string operation)
        {
            _sql += $"{operation} ";

            return this;
        }

        public ISqlQueryBuilder Select(string table, string[] fields)
        {
            _sql += $"SELECT {string.Join(", ", fields)} FROM {table} ";

            return this;
        }

        public ISqlQueryBuilder Where(string field, string value, string operation = "=")
        {
            _sql += $"WHERE {field} {operation} {value} ";

            return this;
        }

        public void Reset()
        {
            _sql = null;
        }

        public string GetSQL()
        {
            string ret = _sql;

            Reset();

            return ret;
        }
    }
}
