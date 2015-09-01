﻿namespace NextLevelSeven.Diagnostics
{
    public static partial class ErrorMessages
    {
        /// <summary>
        ///     German language translation.
        /// </summary>
        private class Deutsch : ErrorMessageLanguage
        {
            public override string GetMessage(ErrorCode code)
            {
                switch (code)
                {
                    case ErrorCode.Unspecified:
                        return "Unbekannter Fehler.";
                }
                return null;
            }
        }
    }
}