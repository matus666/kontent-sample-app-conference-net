// This code was generated by a kontent-generators-net tool 
// (see https://github.com/Kentico/kontent-generators-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System;
using System.Collections.Generic;
using Kentico.Kontent.Delivery;

namespace KenticoKontentModels
{
    public partial class ContactInformation
    {
        public const string Codename = "contact_information";
        public const string PhoneCodename = "phone";
        public const string TitleCodename = "title";
        public const string DecriptionCodename = "decription";
        public const string EmailCodename = "email";

        public string Phone { get; set; }
        public string Title { get; set; }
        public IRichTextContent Decription { get; set; }
        public string Email { get; set; }
        public ContentItemSystemAttributes System { get; set; }
    }
}