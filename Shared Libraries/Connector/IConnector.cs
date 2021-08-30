using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Connector
{
    public interface IConnector
    {

        //private void Close();

        DataReader ExecuteRead();

        DataReader ExecuteReadp();

        DataReader ExecuteRead(string command);

        DataTable ExecuteDataTable();

        DataTable ExecuteDataTablep();

        DataTable ExecuteDataTable(string command);

        object ExecuteScalar();

        object ExecuteScalarp();

        object ExecuteScalar(string command);

        int ExecuteNoneQuery();

        int ExecuteNoneQueryp();

        int ExecuteNoneQuery(string command);

        /*List<List<object[]>> ExecuteMultipleRead(string[] commands);

        List<object> ExecuteMultipleScalar(string[] commands);

        List<int> ExecuteMultipleCount(string[] commands);*/

        void StartCommand(string command);

        void AddValue(object value);

        void AddValue(object value, bool ignore);

        string GetCommand();

        bool Test();
    }
}
