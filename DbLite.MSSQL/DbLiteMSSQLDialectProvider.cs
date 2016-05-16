﻿namespace DbLite.MSSQL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DbLite.Query;
    using System.Data.SqlClient;
    public class DbLiteMSSQLDialectProvider : DbLiteDialectProvider
    {
        public override bool SupportsMultipleInsertValues
        {
            get
            {
                return true;
            }
        }

        public override string RetriveLastIdentity
        {
            get
            {
                return "SELECT SCOPE_IDENTITY()";
            }
        }

        public override DbLiteQueryProvider CreateQueryProvider(IDbConnection connection)
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection));

            return new DbLiteQueryProviderCommon(connection);
        }

        public override void SetParameterDataType(IDbDataParameter parameter, object value)
        {
            base.SetParameterDataType(parameter, value);

            if (value is Guid)
            {
                ((SqlParameter)parameter).SqlDbType = SqlDbType.UniqueIdentifier;
            }
        }

        public override string EscapeColumn(string columnName)
        {
            return Escape(columnName);
        }

        public override string EscapeTable(string tableName)
        {
            return Escape(tableName);
        }

        private string Escape(string name)
        {
            return "[" + name.Replace("[", "[[").Replace("]", "]]") + "]";
        }
    }
}
