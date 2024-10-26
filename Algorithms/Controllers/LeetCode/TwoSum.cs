using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Data.SqlTypes;

namespace Algorithms.Controllers.LeetCode
{
    [ApiController]
    [Route("[controller]")]
    public class TwoSumController : ControllerBase
    {
        /// <summary>
        /// suma dos numeros
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        [HttpPost(Name = "TwoSum")]
        public ActionResult Post([FromBody] int[] nums, int target)
        {
            return Ok(TwoSumNumbers(nums, target));
        }

        [HttpGet(Name = "isPalindrome")]
        public ActionResult Get(int x)
        {

                string numberString = x.ToString();
                char[] array = numberString.ToCharArray();
                Array.Reverse(array);

                string numberRevert = new (array);

                if (numberString == numberRevert) return Ok(true);

                return Ok(false);

        }
        /// <summary>
        /// Given a string s, find the length of the longest substring without repeating characters.
        /// </summary>
        /// <param name="substr">my string</param>
        /// <returns></returns>
               [HttpGet(Name = "GetLengthOfLongestSubstring")]
        public ActionResult GetLengthOfLongestSubstring(string substr)
        {
                string aux = substr[0].ToString();
                string result = "";

                for (int i = 1; i < substr.Length; i++)
                {
                    for (int j = 0; j < substr.Length; j++)
                    {
                        string first = substr[j].ToString();

                        if (aux.Contains(first))
                        {
                            if (result.Length <= aux.Length)
                            {
                                result = aux;
                            }

                        }
                    }
                }
            return Ok(result.Length);
        }

        /// <summary>
        /// Funcion suma dos numeros
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private int[] TwoSumNumbers(int[] nums, int target)
        {

            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var bonus = target - nums[i];


                if (dict.ContainsKey(bonus))
                {
                    return new int[]{dict[bonus], i};
                }
                dict[nums[i]] = i;
            }
            return new int[] { };

        }


    }
}
