using System.Runtime.Serialization;
using MakeEat.Core.Contracts.Data;

namespace MakeEat.Model
{
    public class ResponseModel<T>:IDataModel
    {
        [DataMember]
        public bool Success { get; set; } = true;

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public T Data { get; set; }

        public ResponseModel()
        {
            //this.Data = data;
        }
    }
	//public class ResponseModel: IDataModel
	//{
	//    public bool IsSuccess { get; set; }
	//    public object Object { get; set; }
	//    public string Message { get; set; }
	//}
}
