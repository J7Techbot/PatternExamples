using Builder.Interfaces;

namespace Builder
{
    internal class SqlBuilderDirector
    {
        public void BuildSimpleSelect(ISqlQueryBuilder queryBuilder,string from)
        {
            queryBuilder.Select(from, new string[] { "*" });
        }
        public void BuildWhereSelect(ISqlQueryBuilder queryBuilder, string from, string field, string value)
        {
            queryBuilder.Select(from, new string[] { "*" });
            queryBuilder.Where(field, value);
        }
    }
}
