using System;

namespace LauncherServer.Modelo.TCP
{
    public class EnumStringValueAttribute : Attribute
    {
        public string Value { get; }

        public EnumStringValueAttribute(string value)
        {
            Value = value;
        }
    }

    public static class MsjTCP
    {
        public const string ExtraerJson = "TCP001";
        public const string ActualizaRms = "TCP002";
        public const string ActualizaPdf = "TCP003";
        public const string PruebaConex = "TCP004";
        public const string Actualizar = "TCP005";
        public static string GetStringValue(Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);

            var field = type.GetField(name);
            var attribute = field.GetCustomAttributes(typeof(EnumStringValueAttribute), false) as EnumStringValueAttribute[];

            return attribute != null && attribute.Length > 0 ? attribute[0].Value : null;
        }
    }
}
