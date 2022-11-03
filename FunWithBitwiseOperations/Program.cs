// See https://aka.ms/new-console-template for more information
using static System.Console;
using FunWithBitwiseOperations_;

WriteLine("===== Fun with Bitwise Operations");
ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;
WriteLine("None? {0}", (emailAndPhone | ContactPreferenceEnum.None) == emailAndPhone);
WriteLine("None? {0}", (emailAndPhone | ContactPreferenceEnum.Phone) == emailAndPhone);
WriteLine("None? {0}", (emailAndPhone | ContactPreferenceEnum.Text) == emailAndPhone);