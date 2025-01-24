using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprsPrueba.Domain
{
    internal class ApiObject
    {

        //ATRIBUTOS
        private string id;
        private string name;
        private Dictionary<string, string> data;

//--------------------------------------------------------------------------------------------
        //CONSTRUCTOR
        public ApiObject(string id, string name, Dictionary<string, string> data)
        {
            this.id = id;
            this.name = name;
            this.data = data;
            
        }

        public ApiObject()
        {

        }

//-------------------------------------------------------------------------------------------------
        //GETTERS Y SETTERS
        public string Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}
