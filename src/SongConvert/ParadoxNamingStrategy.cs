using NHibernate.Cfg;

namespace SongConvert
{
    internal class ParadoxNamingStrategy : INamingStrategy
    {
        public string ClassToTableName(string className)
        {
            return Bracket(className);
        }

        public string PropertyToColumnName(string propertyName)
        {
            return propertyName;
        }

        public string TableName(string tableName)
        {
            return Bracket(tableName);
        }

        public string ColumnName(string columnName)
        {
            return Bracket(columnName);
        }

        public string PropertyToTableName(string className,
            string propertyName)
        {
            return Bracket(propertyName);
        }

        public string LogicalColumnName(string columnName,
            string propertyName)
        {
            return string.IsNullOrWhiteSpace(columnName)
                ? Bracket(propertyName)
                : Bracket(columnName);
        }

        private static string Bracket(string raw)
        {
            return $"[{raw}]";
        }
    }
}