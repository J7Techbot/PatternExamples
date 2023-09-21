using Builder.Builders;
using Builder.Interfaces;
using PatternExamples.Patterns.Creational.Builder;

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
            var buildedMySql = _sqlQueryBuilder.GetSQL();
            Console.WriteLine(buildedMySql);

            ///director use
            SqlBuilderDirector builderDirector = new SqlBuilderDirector();
            builderDirector.BuildSimpleSelect(_sqlQueryBuilder, "Food");
            var directorBuildSql = _sqlQueryBuilder.GetSQL();
            Console.WriteLine(directorBuildSql);

            ///alternate use
            _sqlQueryBuilder = new MySqlQueryBuilder();
            var mysql = _sqlQueryBuilder.Select("Food", new string[] { "name", "type", "origin" }).Where("name", "pizza").Operator("AND").Where("type", "salami").GetSQL();
            Console.WriteLine(mysql);

            _sqlQueryBuilder = new MsSqlQueryBuilder();
            var mssql = _sqlQueryBuilder.Select("Food", new string[] { "name", "type", "origin" }).Where("name", "pizza").Operator("AND").Where("type", "salami").GetSQL();
            Console.WriteLine(mssql);
        }
    }
}
