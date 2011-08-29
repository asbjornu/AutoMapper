﻿using System;

namespace AutoMapper.UnitTests.Asbjornu.Resources
{
   public abstract class ResourceBase
   {
      public int Id { get; set; }

      public string Url { get; set; }


      public override string ToString()
      {
         return String.Format("{0} #{1} <{2}>", GetType(), Id, Url);
      }
   }
}