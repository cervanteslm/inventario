using System;

namespace Inventario.DAL
{
    internal class LiteDataBase : IDisposable
    {
        private string dBName;

        public LiteDataBase(string dBName)
        {
            this.dBName = dBName;
        }

        internal object GetCollection<T>(string tableName)
        {
            throw new NotImplementedException();
        }
    }
}