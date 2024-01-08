using Builder.Builders;
using Builder.Interfaces;
using Builder;

namespace Builder
{
    internal class Main
    {
        public void MainMethod()
        {
            ///pattern use
            ISqlQueryBuilder _sqlQueryBuilder = new MySqlQueryBuilder();
            _sqlQueryBuilder.Select("Food", new string[] { "name", "type", "origin" });
            _sqlQueryBuilder.Where("name", "pizza");
            _sqlQueryBuilder.Operator("AND");
            _sqlQueryBuilder.Where("type", "salami");
            var query = _sqlQueryBuilder.GetSQL();
            Console.WriteLine(query);

            ///director use
            SqlBuilderDirector builderDirector = new SqlBuilderDirector();
            builderDirector.BuildSimpleSelect(_sqlQueryBuilder, "Food");
            var directorQuery = _sqlQueryBuilder.GetSQL();
            Console.WriteLine(directorQuery);

            ///alternate use
            _sqlQueryBuilder = new MySqlQueryBuilder();
            query = _sqlQueryBuilder.Select("Food", new string[] { "name", "type", "origin" })
                .Where("name", "pizza")
                .Operator("AND")
                .Where("type", "salami")
                .GetSQL();
            Console.WriteLine(query);

            _sqlQueryBuilder = new MsSqlQueryBuilder();
            query = _sqlQueryBuilder.Select("Food", new string[] { "name", "type", "origin" }).Where("name", "pizza").Operator("AND").Where("type", "salami").GetSQL();
            Console.WriteLine(query);
        }
    }

    internal class Wrong
    {
        string table = "Food";
        string where = "Name = pizza";
        string where2 = "Type = salami";

        private void CreateQuery()
        {
            string query = $"SELECT {table} FROM {new string[] { "name", "type", "origin" }} where {where} AND {where2}";
            Console.WriteLine(query);
        }
    }
}
