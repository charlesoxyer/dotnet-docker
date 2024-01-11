using libbar;
using libfoo;
using static System.Console;

string initialString = StringLibrary.GetString();
string reversedString = StringUtils.ReverseString(initialString);

// Spoof Credential for Testing Secret Scanning Tools
string spoofApiKey = "ABCD1234-FAKE-API-KEY-5678EFGH"; // Fake API Key

WriteLine($"string: {initialString}");
WriteLine($"reversed: {reversedString}");
WriteLine($"Spoof API Key: {spoofApiKey}"); // Displaying spoof credential (for testing only)
