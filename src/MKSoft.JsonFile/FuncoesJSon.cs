using System;
using Newtonsoft.Json;

namespace MKSoft.JsonFile
{
   public static class FuncoesJSon
   {
      public static string ClasseParaJSon<T>(T obj)
      {
         try
         {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
         }
         catch(JsonException e)
         {
            throw new Exception(e.Message);
         }
      }
      public static T JSonParaClass<T>(string jsonString)
      {
         try
         {
           return JsonConvert.DeserializeObject<T>(jsonString);
         }
         catch (JsonException e)
         {
            throw new Exception(e.Message);
         }
      }
   }
}