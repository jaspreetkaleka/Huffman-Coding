using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCoding
{
    static class Huffman
    {
        public static void Encode(IEnumerable<string> msgChars, IEnumerable<string> msgProbs, int numberOfEncodingAlphabets, out Hashtable msgProbabilities, out Hashtable msgCodewords, out double totalProbability, out double entropy_HX, out double L̅, out double efficiency_η, out int minimumCodewordLength, out int maximumCodewordLength)
        {
            msgProbabilities = new Hashtable();
            msgCodewords = new Hashtable();
           
            List<KeyValuePair<string, double>> messages = new List<KeyValuePair<string, double>>();
           
            #region "Set Message and their Probabilities"

            for (int i = 0; i < msgChars.Count(); i++)
            {
                try
                {
                    string prob = msgProbs.ElementAt(i);
                    if (prob.Contains("/"))
                    {
                        messages.Add(new KeyValuePair<string, double>(i.ToString(), Convert.ToDouble(prob.Split(new char[] { '/' })[0]) / Convert.ToDouble(prob.Split(new char[] { '/' })[1])));
                        msgProbabilities.Add(msgChars.ElementAt(i), messages[i].Value);
                    }
                    else
                    {
                        messages.Add(new KeyValuePair<string, double>(i.ToString(), double.Parse(prob)));
                        msgProbabilities.Add(msgChars.ElementAt(i), messages[i].Value);
                    }
                }
                catch { }
            }
            
            List<double> onlyProbabilities_Sorted = new List<double>(new ArrayList(msgProbabilities.Values).ToArray(typeof(double)) as IEnumerable<double>);
            onlyProbabilities_Sorted.Sort();
            onlyProbabilities_Sorted.Reverse();

            totalProbability = onlyProbabilities_Sorted.Sum();
            
            #endregion

            #region "Encode the message."

            List<string> encodingAlphabets = GetEncodingAlphabets(numberOfEncodingAlphabets);

            List<KeyValuePair<int, string>> encodedMsg = GetEncodedMessages(EncodedString(messages, encodingAlphabets), encodingAlphabets);

            encodedMsg.Sort(delegate(KeyValuePair<int, string> kvp1, KeyValuePair<int, string> kvp2)
                {
                    return Comparer<int>.Default.Compare(kvp1.Key, kvp2.Key);
                });

            #endregion

            #region "Map the code words to the corresponding messages."

            for (int i = 0; i < onlyProbabilities_Sorted.Count; i++)
            {
                msgCodewords.Add(msgChars.ElementAt(i), encodedMsg[i].Value);
            }

            #endregion

            #region "Calculate Entropy"

            entropy_HX = 0;
            for (int i = 0; i < onlyProbabilities_Sorted.Count; i++)
            {
                if (onlyProbabilities_Sorted[i] != 0)
                {
                    entropy_HX = entropy_HX + onlyProbabilities_Sorted[i] * Math.Log(onlyProbabilities_Sorted[i], 2);
                }
            }
            entropy_HX = -entropy_HX;

            #endregion

            #region "Calculate average length per codeword, L̅"

            maximumCodewordLength = 0;
            minimumCodewordLength = 0;
            L̅ = 0;
            for (int i = 0; i < encodedMsg.Count; i++)
            {
                int codewordLength = encodedMsg[i].Value.Length - encodedMsg[i].Value.Replace(",", "").Length + 1;
                L̅ = L̅ + messages[i].Value * codewordLength;
                if (maximumCodewordLength < codewordLength)
                {
                    maximumCodewordLength = codewordLength;
                }
                if (minimumCodewordLength > codewordLength)
                {
                    minimumCodewordLength = codewordLength;
                }
            }

            #endregion

            #region "Calculate Efficiency"

            efficiency_η = entropy_HX / (L̅ * Math.Log(numberOfEncodingAlphabets, 2)) * 100;

            #endregion
        }

        public static List<string> GetEncodingAlphabets(int alphabetCount)
        {
            List<string> eA = new List<string>();
            if (alphabetCount == 2)
            {
                eA.Add("0");
                eA.Add("1");
            }
            else if (alphabetCount % 2 == 0)
            {
                int x = alphabetCount / 2;

                for (int i = -x; i <= x; i++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    eA.Add(i.ToString());
                }
            }
            else
            {
                int x = (alphabetCount - 1) / 2;

                for (int i = -x; i <= x; i++)
                {
                    eA.Add(i.ToString());
                }
            }
            eA.Reverse();
            return eA;
        }

        private static List<KeyValuePair<int, string>> GetEncodedMessages(string encodedString, List<string> encodingAlphabets)
        {
            List<KeyValuePair<int, string>> eMsg = new List<KeyValuePair<int, string>>();

            string subString = encodedString.Substring(1, encodedString.Length - 2);
            List<string> subParts = new List<string>();

            while (subString != "")
            {
                if (subString.StartsWith("<"))
                {
                    int openBracketCount = 0;
                    int closeBracketCount = 0;
                    for (int i = 0; i < subString.Length; i++)
                    {
                        if (subString[i] == '<')
                        {
                            openBracketCount++;
                        }
                        else if (subString[i] == '>')
                        {
                            closeBracketCount++;
                        }

                        if (openBracketCount == closeBracketCount)
                        {
                            subParts.Add(subString.Substring(0, i + 1));
                            subString = subString.Replace(subParts.Last(), "");
                            break;
                        }
                    }
                }
                else if (subString.StartsWith(","))
                {
                    subString = subString.Substring(1);
                }
                else
                {
                    if (subString.Contains(","))
                    {
                        subParts.Add(subString.Substring(0, subString.IndexOf(',')));
                        subString = subString.Substring(subString.IndexOf(",") + 1);
                    }
                    else
                    {
                        subParts.Add(subString);
                        subString = "";
                    }
                }
            }

            for (int i = 0; i < subParts.Count; i++)
            {
                if (subParts[i].StartsWith("<"))
                {
                    List<KeyValuePair<int, string>> temp = GetEncodedMessages(subParts[i], encodingAlphabets);
                    
                    for (int j = 0; j < temp.Count; j++)
                    {
                        temp[j] = new KeyValuePair<int, string>(temp[j].Key, encodingAlphabets[i] + "," + temp[j].Value);
                    }
                    eMsg.AddRange(temp);
                }
                else
                {
                    eMsg.Add(new KeyValuePair<int, string>(Convert.ToInt32(subParts[i]), encodingAlphabets[i]));
                }
            }
            return eMsg;
        }

        private static string EncodedString(IEnumerable<KeyValuePair<string, double>> messages, IEnumerable<string> encodingAlphabets)
        {
            int M = encodingAlphabets.Count();
            List<KeyValuePair<string, double>> msg = new List<KeyValuePair<string, double>>();
            msg.AddRange(messages);

            #region "Sort the messages in order of decreasing probabilities."

            msg.Sort
            (
                delegate(KeyValuePair<string, double> kvp1, KeyValuePair<string, double> kvp2)
                {
                    return Comparer<double>.Default.Compare(kvp1.Value, kvp2.Value);
                }
            );

            msg.Reverse();

            #endregion

            if (msg.Count <= M)
            {
                string codeSequence = "<";
                for (int i = 0; i < msg.Count; i++)
                {
                    codeSequence = codeSequence + msg[i].Key.ToString() + ",";
                }
                codeSequence = codeSequence.Trim(new char[] { ',' }) + ">";
                return codeSequence;
            }
            else
            {
                double sum = 0;
                string codeSequence = "<";
                for (int i = M; i > 0; i--)
                {
                    codeSequence = codeSequence + msg[msg.Count - i].Key.ToString() + ",";
                    sum = sum + msg[msg.Count - i].Value;
                }
                codeSequence = codeSequence.Trim(new char[] { ',' }) + ">";

                List<KeyValuePair<string, double>> subMsg = new List<KeyValuePair<string, double>>();
                subMsg.AddRange(msg.Take(msg.Count - M));
                subMsg.Add(new KeyValuePair<string, double>(codeSequence, sum));

                return EncodedString(subMsg, encodingAlphabets);
            }
        }

    }
}
