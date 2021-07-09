using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace MyUI
{
    public class UI
    {
        public class UIEntry
        {
            public string name;     //entry name
            public dynamic value;   //entry value
            public dynamic max;     //max value
            public Type type;       //entry value type
            public dynamic control; //entry control handle

            public UIEntry()
            {
            }

            /* initialize value to specific type */
            public UIEntry(dynamic value, dynamic max, string name)
            {
                if (value.GetType() == typeof(double))
                    this.value = Convert.ChangeType(value, typeof(double));
                else
                    this.value = value;
                this.type = this.value.GetType();
                this.name = name;
                this.max = max;
            }
        }

        //initialize the TextBox with entrys
        public static void controls_set(dynamic form, Dictionary<String, UI.UIEntry> entrys)
        {
            foreach (Control control in form.Controls)
            {
                control.InvokeOnUIThread(() => {
                    if (control is TextBox)
                    {
                        foreach (KeyValuePair<String, UIEntry> item in entrys)
                        {
                            if (item.Value.name == control.Name)
                            {
                                control.Text = entrys[item.Key].value.ToString(); // update textbox text
                                entrys[item.Key].control = control as TextBox;   // save this textbox handler
                                                                                 //console_printline("set:" + control.Name);
                            }
                        }
                    }

                    if (control is CheckBox)
                    {
                        foreach (KeyValuePair<String, UIEntry> item in entrys)
                        {
                            if (item.Value.name == control.Name)
                            {
                                CheckBox control_new = control as CheckBox; ;
                                control_new.Checked = entrys[item.Key].value;
                                entrys[item.Key].control = control as CheckBox;   // save this textbox handler
                                                                                  //console_printline("set:" + control.Name);
                            }
                        }
                    }

                    if (control is RadioButton)
                    {
                        foreach (KeyValuePair<String, UIEntry> item in entrys)
                        {
                            if (item.Value.name == control.Name)
                            {
                                RadioButton control_new = control as RadioButton; ;
                                control_new.Checked = entrys[item.Key].value;
                                entrys[item.Key].control = control as RadioButton;   // save this textbox handler
                                                                                  //console_printline("set:" + control.Name);
                            }
                        }
                    }

                    control.Update();
                    if (control.HasChildren)
                    {
                        controls_set(control, entrys);
                    }
                });
            }
        }

        public static void controls_get(dynamic form, ref Dictionary<String, UIEntry> entrys)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    foreach (KeyValuePair<String, UIEntry> item in entrys)
                    {
                        if (item.Value.name == control.Name)
                        {
                            try
                            {
                                entrys[item.Key].value = Convert.ChangeType(control.Text, entrys[item.Key].type);
                                if ((entrys[item.Key].value.GetType() != typeof(string)) || (entrys[item.Key].value.GetType() != typeof(bool)))
                                {
                                    if (entrys[item.Key].value > entrys[item.Key].max)
                                        entrys[item.Key].value = entrys[item.Key].max;
                                    if (entrys[item.Key].value < 0)
                                        entrys[item.Key].value = 0;
                                }
                                entrys[item.Key].control = (TextBox)control;
                                //string val = Convert.ToString(entrys[item.Key].value);
                                //console_printline("get:" + control.Name + "=" + val);
                            }
                            catch
                            {
                                Debug.WriteLine("type convert error");
                            }

                        }
                    }
                }
                if (control is CheckBox)
                {
                    foreach (KeyValuePair<String, UIEntry> item in entrys)
                    {
                        if (item.Value.name == control.Name)
                        {
                            try
                            {
                                CheckBox checkBox = control as CheckBox;
                                entrys[item.Key].value = checkBox.Checked;
                                entrys[item.Key].control = (CheckBox)control;
                                //string val = Convert.ToString(entrys[item.Key].value);
                                //console_printline("get:" + control.Name + "=" + val);
                            }
                            catch
                            {
                                Debug.WriteLine("type convert error");
                            }

                        }
                    }
                }

                if (control is RadioButton)
                {
                    foreach (KeyValuePair<String, UIEntry> item in entrys)
                    {
                        if (item.Value.name == control.Name)
                        {
                            try
                            {
                                RadioButton rdb = control as RadioButton;
                                entrys[item.Key].value = rdb.Checked;
                                entrys[item.Key].control = (RadioButton)control;
                                //string val = Convert.ToString(entrys[item.Key].value);
                                //console_printline("get:" + control.Name + "=" + val);
                            }
                            catch
                            {
                                Debug.WriteLine("type convert error");
                            }

                        }
                    }
                }

                if (control.HasChildren)
                {
                    controls_get(control, ref entrys);
                }
            }
        }

        public static void csv_save(Dictionary<String, UIEntry> entrys, string fileName)
        {
            if ((fileName == null) || (fileName == ""))
                return;

            using (StreamWriter file = new StreamWriter(fileName, false))
            {
                foreach (KeyValuePair<string, UIEntry> item in entrys)
                {
                    file.Write(item.Key + ",");
                    file.WriteLine(item.Value.value);
                }
            }
        }

        public static void csv_get(string fileName, ref Dictionary<String, UIEntry> entrys)
        {
            String line;
            char[] delimiterChars = { ',', '\r', '\n' };
            String[] values;
            String key;
            object value;
            if (File.Exists(fileName))
            {
                try
                {
                    using (FileStream file = File.OpenRead(fileName))
                    {
                        using (StreamReader fstream = new StreamReader(file))
                        {
                            do
                            {
                                line = fstream.ReadLine();
                                values = line.Split(delimiterChars);
                                key = values[0];
                                value = values[1];

                                foreach (KeyValuePair<string, UIEntry> item in entrys)
                                {
                                    if (item.Key == key)
                                    {
                                        item.Value.value = Convert.ChangeType(value, item.Value.type);
                                    }
                                }
                                //entrys.Where(x => x.Key == key).Select(x => x.Value.value = Convert.ChangeType(value, x.Value.type));

                            } while (!(fstream.Peek() == -1));
                        }
                    }
                    Debug.WriteLine("Read " + fileName + " successfully");
                }
                catch
                {
                    String out_string = "File read failed!!\n Maybe already opened!!";
                    Debug.WriteLine(out_string);
                    MessageBox.Show(out_string);
                }
            }
            else
            {
                String out_string = fileName + " not found";
                Debug.WriteLine(out_string);
                MessageBox.Show(out_string);
            }
        }

        public static void console_clear(RichTextBox control)
        {
            control.Text = String.Empty;
        }

        public static void console_print(RichTextBox control, String line)
        {
            if (control != null)
            {
                control.InvokeOnUIThread(() =>
                {
                    if (!control.IsHandleCreated)
                        return;

                    control.AppendText(line);
                    // set the current caret position to the end
                    control.SelectionStart = control.Text.Length;
                    // scroll it automatically
                    control.ScrollToCaret();
                    control.Update();
                });
            }           
            Application.DoEvents();
        }

        public static void console_print(RichTextBox box, String line, Color color)
        {
            if (box != null)
            {
                box.InvokeOnUIThread(() =>
                {
                    if (!box.IsHandleCreated)
                        return;

                    box.SelectionStart = box.TextLength;
                    box.SelectionLength = 0;

                    box.SelectionColor = color;

                    box.AppendText(line);
                    // set the current caret position to the end
                    box.SelectionStart = box.Text.Length;
                    // scroll it automatically
                    box.ScrollToCaret();
                    box.Update();
                });
            }
            Application.DoEvents();
        }

        public static void console_printline(RichTextBox box, String line)
        {
            String line_return = line + "\n";
            box.InvokeOnUIThread(() =>
            {
                if (box != null)
                    console_print(box, line_return);
            });
        }

        public static void set_form_location(Form form, Point location, int width, int height)
        {
            if (form == null)
                return;
            form.Location = location;
            form.Height = height;
            form.Width = width;
            //Debug.WriteLine($"{form.Name} Location = {location}, width = {width}, height = {height}");            
        }

        public static Size get_screen_resolotion()
        {
            return Screen.PrimaryScreen.WorkingArea.Size;
        }

        // https://bettersolutions.com/csharp/syntax/inputbox.htm
        // https://dotblogs.com.tw/aquarius6913/2014/09/03/146444
        public static System.Windows.Forms.DialogResult InputBox(string title, string promptText, ref string value)
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
            System.Windows.Forms.Button buttonOk = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonCancel = new System.Windows.Forms.Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | System.Windows.Forms.AnchorStyles.Right;
            buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new System.Windows.Forms.Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(System.Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            System.Windows.Forms.DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        public static void print_entrys(Dictionary<String, UIEntry> entrys)
        {           
            foreach (KeyValuePair<String, UIEntry> item in entrys)
            {
                Console.WriteLine($"{item.Key}, {item.Value.value}");
            }            
        }


        /*
         * Print all the controls properiteries
         */
        public static void print_ui_controls(dynamic ui)
        {
            foreach (Control control in ui.Controls)
            {
                if (control is TextBox)
                {
                    TextBox control_retype = control as TextBox;
                    Console.WriteLine($"{control_retype.Name}, {control_retype.Text}");
                }
                if (control is CheckBox)
                {
                    CheckBox control_retype = control as CheckBox;
                    Console.WriteLine($"{control_retype.Name}, {control_retype.Checked}");
                }
                if (control is RadioButton)
                {
                    RadioButton control_retype = control as RadioButton;
                    Console.WriteLine($"{control_retype.Name}, {control_retype.Checked}");
                }

                if (control.HasChildren)
                {
                    print_ui_controls(control);                    
                }
            }
        }

        
        public static void set_textbox_color(dynamic form, Color color)
        {
            foreach (Control control in form.Controls)
            {
                control.InvokeOnUIThread(() => {
                    if (control is TextBox)
                    {
                        TextBox control_retype = control as TextBox;
                        control_retype.ForeColor = color;
                        control.Update();
                    }
                    
                    if (control.HasChildren)
                    {
                        set_textbox_color(control, color);
                    }
                });
            }
        }

    }

    /// <summary>
    /// InVoke UI in Thread
    /// </summary>
    //https://stackoverflow.com/questions/60014173/avoid-blocking-the-form-without-using-application-doevents
    public static class ControlExtensions
    {
        public static void InvokeOnUIThread(this Control control, Action action)
        {
            if (control == null)
                return;
            if (control.IsDisposed)
                return;

            try
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(action);
                }
                else
                {
                    action();
                }
            }
            catch (Exception ex)
            {
                // log with exception here
                Console.WriteLine("===========exception error================");
                Console.WriteLine(ex);
                Console.WriteLine("==========================================");
            }

        }
    }
}
