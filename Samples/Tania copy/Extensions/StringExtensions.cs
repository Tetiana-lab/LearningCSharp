
namespace Tania.Extensions
{
    public static class StringExtensions
    {
        public static string ToCrAzYcAsE(this string value){
           char[] chars = new char[value.Length +1];
            var newString = "";
            int conter =0;
            bool isUpper = true;
            foreach (var item in value)
            {
                var numRepr = (int)item;
                if(!isUpper && numRepr > 65 && numRepr < 90) //upper
                {
                    numRepr += 32;
                }
                else if(isUpper && numRepr >= 97 && numRepr <= 122) //lower
                {
                    numRepr -= 32;
                }
                conter++;
                chars[conter] = (char)numRepr;
                isUpper = !isUpper;
            }

            return new string(chars);
        }

           public static string ToInvertCase(this string value){
           char[] chars = new char[value.Length +1];
            var newString = "";
            int conter =0;
            foreach (var item in value)
            {
                var numRepr = (int)item;
                if(numRepr > 65 && numRepr < 90)
                {
                    numRepr += 32;
                }
                else if(numRepr >= 97 && numRepr <= 122)
                {
                    numRepr -= 32;
                }
                conter++;
                chars[conter] = (char)numRepr;
            }

            return new string(chars);
        }
    }
}