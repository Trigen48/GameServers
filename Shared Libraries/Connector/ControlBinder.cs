using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Connector
{
    public class ControlBinder
    {

        DataReader reader;

        //List<KeyValuePair<object, Control>> Binders = new List<KeyValuePair<object, Control>>();

        public ControlBinder()
        {
           System.Data.DataTable tb= new System.Data.DataTable();
            
        }

        public ControlBinder(DataReader reader)
        {
            Load(reader);
            
        }

        public void Load(DataReader reader)
        {
            if (reader == null)
            {
                throw new Exception("Reader cannot be null");
            }

            this.reader = reader;
        }

        public bool NextRow()
        {
            return reader.NextRow();
        }

        public bool BindControl(Control bind)
        {
            if (!reader.CanRead)
                return false;

            try
            {
                object v = reader.GetValue();

                return BindControlD(bind, v);
            }
            catch
            {
            }

            return false;
        }

        public bool BindControl(Control bind, string FieldKey)
        {
            if (!reader.CanRead)
                return false;

            try
            {
                object v = reader.GetValue(FieldKey);

                return BindControlD(bind, v);
            }
            catch
            {
            }

            return false;
        }

        public bool BindControl(Control bind, int index)
        {

            if (!reader.CanRead)
                return false;

            try
            {
                object v = reader.GetValue(index);

                return BindControlD(bind, v);
            }
            catch
            {
            }

            return false;
        }

        private bool BindControlD(Control bind,object v)
        {
            try
            {

                Type t = bind.GetType();


                if (t == typeof(TextBox))
                {
                    ((TextBox)bind).Text = v.ToString();
                }
                else if (t == typeof(CheckBox))
                {
                    ((CheckBox)bind).Checked = Convert.ToBoolean(v);
                }
                else if (t == typeof(DateTimePicker))
                {
                    ((DateTimePicker)bind).Value = Convert.ToDateTime(v);
                }
                else if (t == typeof(NumericUpDown))
                {
                    ((NumericUpDown)bind).Value = Convert.ToDecimal(v);
                }
                else if (t == typeof(Button))
                {
                    ((Button)bind).Text = v.ToString();
                }
                else if (t == typeof(Label))
                {
                    ((Label)bind).Text = v.ToString();
                }
                else if (t == typeof(LinkLabel))
                {
                    ((LinkLabel)bind).Text = v.ToString();
                }
                else if (t == typeof(RichTextBox))
                {
                    ((RichTextBox)bind).Text = v.ToString();
                }
                else if (t == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)bind).Text = v.ToString();
                }
                else if (t == typeof(MonthCalendar))
                {
                    ((MonthCalendar)bind).SetDate(Convert.ToDateTime(v));
                }
                else if (t == typeof(ComboBox))
                {

                    if (((ComboBox)bind).DataSource == null)
                    {
                        switch (((ComboBox)bind).DropDownStyle)
                        {
                            case ComboBoxStyle.DropDown:
                                ((ComboBox)bind).Text = v.ToString();
                                break;

                            case ComboBoxStyle.DropDownList:


                                ((ComboBox)bind).SelectedItem = v;

                                break;

                            case ComboBoxStyle.Simple:
                                ((ComboBox)bind).Text = v.ToString();
                                break;
                        }
                    }
                    else
                    {
                        switch (((ComboBox)bind).DropDownStyle)
                        {
                            case ComboBoxStyle.DropDown:
                                ((ComboBox)bind).SelectedText = v.ToString();
                                break;

                            case ComboBoxStyle.DropDownList:


                                ((ComboBox)bind).SelectedValue  = v;

                                break;

                            case ComboBoxStyle.Simple:
                                ((ComboBox)bind).SelectedValue = v.ToString();
                                break;
                        }
                    }
                }
                else if (t == typeof(ListBox))
                {
                    ((ListBox)bind).SelectedItem = v;

                }

            }
            catch
            {
                throw new Exception("Could not bind control");
            }


            return false;
        }

        public void Close()
        {
            if(reader==null)
                throw new Exception("Reader is null");

            reader.Close();
            reader = null;
        }

  

    }
}
