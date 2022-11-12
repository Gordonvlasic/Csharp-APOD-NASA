using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPI
{
    //Here lies the famous POCO - (Plain Old C-sharp Object)
    //Now depending on where you are collecting your data, this is where you are 
    //Simply going to fill in the JSON properities such as in the example below.
    internal class POCOS
    {
        //The = String.Empty; is nothing mandatory, just cleans up Null warnings.
        public string Copyright { get; set; } = String.Empty;
        public string Date { get; set; } = String.Empty;
        public string Explanation { get; set; } = String.Empty;
        public string Hdurl { get; set; } = String.Empty;
        public string Media_type { get; set; } = String.Empty;
        public string Service_version { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Url { get; set; } = String.Empty;

        //Override ToString statement to give us our desired output when the data is collected from the target.
        public override string ToString()
        {
            return $"\nThe Title of this photo is {Title}.\n\nA short explanation of the photo \n\n{Explanation}." +
                $"\n\nThe image can be found at the link below.\n\n{Hdurl}";    
        }
    }
}
