using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Azure_API.Model
{
    public class FuncionarioLog
    {
        public /*Enum*/ TipoAcao { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public /*struct*/ Etag { get; set; }
        // o jeito certo seria fazer essa classe mas nao sei como se faz isso, acho que ainda fiz errado o resto
    }
}