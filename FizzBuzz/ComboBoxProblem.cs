using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FizzBuzz
{
    public static class ComboBoxProblem
    {
        private static string RetrievePropertyNameWithAttribute<TAttribute>(Type type) where TAttribute : Attribute
        {
            // Gets the first property of 'type' that contains the attribute of type TAttribute.
            return type.GetProperties().First(pi => pi.GetCustomAttributes(true).OfType<TAttribute>().FirstOrDefault() != null).Name;
        }

        public static void AssignComboBox()
        {
            var comboBox1 = new ComboBox();
            var table1ElementType = Tables.Table1.GetType().GetElementType();
            comboBox1.ValueMember = RetrievePropertyNameWithAttribute<ValueMemberAttribute>(table1ElementType);
            comboBox1.DisplayMember = RetrievePropertyNameWithAttribute<DisplayMemberAttribute>(table1ElementType);
            comboBox1.DataSource = Tables.Table1;

            var comboBox2 = new ComboBox();
            var table2ElementType = Tables.Table2.GetType().GetElementType();
            comboBox2.ValueMember = RetrievePropertyNameWithAttribute<ValueMemberAttribute>(table2ElementType);
            comboBox2.DisplayMember = RetrievePropertyNameWithAttribute<DisplayMemberAttribute>(table2ElementType);
            comboBox2.DataSource = Tables.Table2;
        }
    }

    public class IdName
    {
        [ValueMember]
        public string ID { get; set; }
        [DisplayMember]
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class IdDescription
    {
        [ValueMember]
        public string ID { get; set; }
        [DisplayMember]
        public string Description { get; set; }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class DisplayMemberAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.All)]
    public class ValueMemberAttribute : Attribute
    {
    }

    public static class Tables
    {
        public static readonly IdName[] Table1 =
        {
            new IdName {ID = "1", Name = "Something1", Description = "Description1"},
            new IdName {ID = "2", Name = "Something2", Description = "Description2"},
            new IdName {ID = "3", Name = "Something3", Description = "Description3"}
        };

        public static readonly IdDescription[] Table2 =
        {
            new IdDescription {ID = "1", Description = "Description1"},
            new IdDescription {ID = "2", Description = "Description2"},
            new IdDescription {ID = "3", Description = "Description3"}
        };
    }
}
