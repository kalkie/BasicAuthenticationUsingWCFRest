﻿// BasicAuthenticationUsingWCF a library to add Basic Authenticaion
// to a WCF REST based service
//
// Patrick Kalkman  pkalkie@gmail.com
//
// (C) Patrick Kalkman http://www.semanticarchitecture.net
//

namespace BasicAuthenticationUsingWCF
{
   /// <summary>
   /// This class hold the credentials of a user.
   /// </summary>
   internal class Credentials
   {
      public Credentials(string userName, string password)
      {
         this.UserName = userName;
         this.Password = password;
      }

      public string UserName { get; private set; }

      public string Password { get; private set; }
   }
}