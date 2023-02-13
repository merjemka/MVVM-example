using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class HelloWorldModel
    {
        //provides data for the ViewModel by pulling it from the repository - GetData method
        private List<string> repositoryData;
        public string ImportantInfo
        {
            get { return ConcatenateData(repositoryData); }
        }
        public HelloWorldModel()
        {
            repositoryData = GetData();
        }

        private List<string> GetData()
        {
            repositoryData = new List<string>();
           
            return repositoryData;
        }

        private string ConcatenateData(List<string> dataList) {
            string importantInfo = dataList.ElementAt(0) + ", " + dataList.ElementAt(1) + "!";
            return importantInfo;
        }
    }
    
}
