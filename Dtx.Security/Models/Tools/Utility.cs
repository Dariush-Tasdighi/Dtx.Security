namespace Models
{
    public static class Utility
    {
        static Utility()
        {
        }


        private static string numericCharacters = "0123456789";

        private static string specialCharacters = "!@#$%^&*~`";

        private static string alphaCharacters = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// ساخت رشته به صورت رندوم و اتفاقی
        /// </summary>
        /// <param name="lenght">طول رشته</param>
        /// <param name="isContainUpperAlpha">شامل حروف بزرگ</param>
        /// <param name="isContainLowerAlpha">شامل حروف کوچک</param>
        /// <param name="isContainNumber">شامل اعداد</param>
        /// <param name="isContainSpecialCharacter">شامل کاراکترهای ویژه</param>
        /// <param name="repeatAsSame">کاراکترها یک دست شامل همه باشد</param>
        /// <returns></returns>
        public static string GetRandomString
            (
                int lenght,
                bool isContainUpperAlpha = false,
                bool isContainLowerAlpha = false,
                bool isContainNumber = false,
                bool isContainSpecialCharacter = false,
                bool repeatAsSame = false
            )
        {
            //یک تابع می‌خواهم نوشته شود که یک کلمه تصادفی (مثلا برای گذرواژه) برگرداند... و 
            //به عنوان ورودی اینکه در کلمه اعداد باشد یا خیر - 
            //حروف انگلیسی کوچک باشد یا خیر - 
            //حروف انگلیسی بزرگ باشد یا خیر - 
            //کاراکترهای خاص مانند %$# داشته باشد یا خیر 
            //و طول رشته را بگیرد 
            //با بهترین روش‌هایی که تولید اطلاعات تصادفی می‌کند یک رشته برگرداند.

            if (lenght < 0)
            {
                throw new System.ArgumentException("String length must be positive!", "stringLenght");
            }

            if (lenght > short.MaxValue / 8)
            {
                throw new System.ArgumentException("String length is too big!", "stringLenght");
            }

            if (isContainNumber == false &&
                isContainLowerAlpha == false &&
                isContainLowerAlpha == false &&
                isContainSpecialCharacter == false)
            {
                throw new System.ArgumentException("Set one Charater Dataset Option", "isContainLowerAlpha");
            }

            var randomStringResult = "";
            string stringDataSet;
            var random = new System.Random();

            if (repeatAsSame) //همه کاراکترها تکرار شده باشند
            {
                stringDataSet = "";
                if (isContainUpperAlpha)
                {
                    stringDataSet += alphaCharacters.ToUpper();
                }

                if (isContainNumber)
                {
                    stringDataSet += numericCharacters;
                }

                if (isContainSpecialCharacter)
                {
                    stringDataSet += specialCharacters;
                }

                if (isContainLowerAlpha)
                {
                    stringDataSet += specialCharacters;
                }
            }
            else
            {
                if (isContainUpperAlpha)
                {
                    //فرض بر این است که برای حروف بزرگ، فقط یک مورد کافی هست
                    randomStringResult += GeneratRandomCharacter(random, alphaCharacters.ToUpper());
                }

                if (isContainNumber)
                {
                    //فرض بر این است که برای اعداد، فقط یک مورد کافی هست
                    randomStringResult += GeneratRandomCharacter(random, numericCharacters);
                }

                if (isContainSpecialCharacter)
                {
                    //فرض بر این است که برای کاراکترهای ویژه، فقط یک مورد کافی هست
                    randomStringResult += GeneratRandomCharacter(random, specialCharacters);
                }

                if (isContainLowerAlpha)
                {
                    stringDataSet = alphaCharacters;
                }
                else if (isContainUpperAlpha)
                {
                    stringDataSet = specialCharacters.ToUpper();
                }
                else if (isContainSpecialCharacter)
                {
                    stringDataSet = specialCharacters;
                }
                else //if (isContainNumber)
                {
                    stringDataSet = numericCharacters;
                }
            }

            for (int intIndex = randomStringResult.Length; intIndex < lenght; intIndex++)
            {
                string randomChar;
                do
                {

                    randomChar = GeneratRandomCharacter(random, stringDataSet);

                } while (randomStringResult.Contains(randomChar) && stringDataSet.Length >= randomStringResult.Length);

                randomStringResult += randomChar;
            }

            if (randomStringResult.Length > lenght)
            {
                //حالتی که تعداد کاراکتر انتخابی با توجه با موارد کاراکترهای درگیری، بزرگتر از طول رشته خروجی باشد
                randomStringResult = randomStringResult.Substring(0, lenght);
            }

            return randomStringResult;
        }

        private static string GeneratRandomCharacter(System.Random random, string stringDataset)
        {
            return stringDataset[random.Next(stringDataset.Length)].ToString();
        }

        public static System.DateTime Now
        {
            get
            {
                //string currentCultureName =
                //	System.Threading.Thread.CurrentThread.CurrentCulture.Name;

                System.Globalization.CultureInfo currentCulture =
                    System.Threading.Thread.CurrentThread.CurrentCulture;

                System.Globalization.CultureInfo englishCulture =
                    new System.Globalization.CultureInfo(name: "en-US");

                System.Threading.Thread.CurrentThread.CurrentCulture = englishCulture;

                System.DateTime now = System.DateTime.Now;

                System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;

                return now;
            }
        }
    }
}
