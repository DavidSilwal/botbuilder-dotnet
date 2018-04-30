// <auto-generated>
// Code generated by LUISGen ..\..\..\..\LUISGenTest\Contoso App.json -cs Microsoft.Bot.Builder.Ai.LUIS.Tests.Contoso_App
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Microsoft.Bot.Builder.Ai.LUIS.Tests
{
    public class Contoso_App: Microsoft.Bot.Builder.Core.Extensions.IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Cancel, 
            Delivery, 
            EntityTests, 
            Greeting, 
            Help, 
            None, 
            SpecifyName, 
            Travel, 
            Weather_GetForecast
        };
        public Dictionary<Intent, Microsoft.Bot.Builder.Ai.LUIS.IntentData> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Name;
            public string[] State;
            public string[] Weather_Location;
            public string[] City;
            public string[] To;
            public string[] From;

            // Built-in entities
            public Microsoft.Bot.Builder.Ai.LUIS.Age[] Builtin_age;
            public Microsoft.Bot.Builder.Ai.LUIS.DateTimeSpec[] Builtin_datetime;
            public Microsoft.Bot.Builder.Ai.LUIS.Dimension[] Builtin_dimension;
            public string[] Builtin_email;
            public Microsoft.Bot.Builder.Ai.LUIS.Money[] Builtin_money;
            public double[] Builtin_number;
            public double[] Builtin_ordinal;
            public double[] Builtin_percentage;
            public string[] Builtin_phonenumber;
            public Microsoft.Bot.Builder.Ai.LUIS.Temperature[] Builtin_temperature;
            public string[] Builtin_url;

            // Lists
            public string[][] Airline;

            // Composites
            public class _InstanceAddress
            {
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_number;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] State;
            }
            public class AddressClass
            {
                public double[] Builtin_number;
                public string[] State;
                [JsonProperty("$instance")]
                public _InstanceAddress _instance;
            }
            public AddressClass[] Address;

            public class _InstanceComposite1
            {
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_age;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_datetime;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_dimension;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_email;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_money;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_number;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_ordinal;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_percentage;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_phonenumber;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_temperature;
            }
            public class Composite1Class
            {
                public Microsoft.Bot.Builder.Ai.LUIS.Age[] Builtin_age;
                public Microsoft.Bot.Builder.Ai.LUIS.DateTimeSpec[] Builtin_datetime;
                public Microsoft.Bot.Builder.Ai.LUIS.Dimension[] Builtin_dimension;
                public string[] Builtin_email;
                public Microsoft.Bot.Builder.Ai.LUIS.Money[] Builtin_money;
                public double[] Builtin_number;
                public double[] Builtin_ordinal;
                public double[] Builtin_percentage;
                public string[] Builtin_phonenumber;
                public Microsoft.Bot.Builder.Ai.LUIS.Temperature[] Builtin_temperature;
                [JsonProperty("$instance")]
                public _InstanceComposite1 _instance;
            }
            public Composite1Class[] Composite1;

            public class _InstanceComposite2
            {
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Airline;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] City;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_url;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] From;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] To;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Weather_Location;
            }
            public class Composite2Class
            {
                public string[][] Airline;
                public string[] City;
                public string[] Builtin_url;
                public string[] From;
                public string[] To;
                public string[] Weather_Location;
                [JsonProperty("$instance")]
                public _InstanceComposite2 _instance;
            }
            public Composite2Class[] Composite2;

            // Instance
            public class _Instance
            {
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Name;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] State;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Weather_Location;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] City;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] To;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] From;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_age;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_datetime;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_dimension;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_email;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_money;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_number;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_ordinal;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_percentage;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_phonenumber;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_temperature;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Builtin_url;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Airline;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Address;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Composite1;
                public Microsoft.Bot.Builder.Ai.LUIS.InstanceData[] Composite2;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Contoso_App>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }
    }
}
