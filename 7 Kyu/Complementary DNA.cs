public class DnaStrand 
    {
        public static string MakeComplement(string dna)
        {
            char[] arr = dna.ToCharArray();
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                switch(arr[i])
                {
                case 'A': str += "T";
                    break;
                case 'T': str += "A";
                    break;
                case 'C': str += "G";
                    break;
                case 'G': str += "C";
                    break;
                }
            }
            return str;
        }
    }