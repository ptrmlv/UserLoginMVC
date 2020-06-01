using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace UserLoginMVC.Controller
{
   
        static public class Logger
        {
            static private List<string> currentSessionActivities = new List<string>();
        static String sb = " ";

            static public void LogActivity(string activity)
            {
                string activityLine = Environment.NewLine + DateTime.Now + ";"
                    + LoginValidation.currUser + ";"
                    + LoginValidation.currentUserRole + ";"
                    + activity;
                if (File.Exists("Log.txt") == true)
                {
                    File.AppendAllText("Log.txt", activityLine);
                }
                currentSessionActivities.Add(activityLine);
            }
            static public void GetCurrentSessionActivities()
            {
            sb = " ";
                foreach (var a in currentSessionActivities)
                {
                sb = sb + a;
                }
            MessageBox.Show(sb);
        }
            static public void GetLoggedInCount(string name)
            {
                int logCount = 0;
                List<string> allLines = File.ReadAllLines("Log.txt").ToList();
                foreach (var l in allLines)
                {
                    Match match = Regex.Match(l, @"\d{2}\/\d{2}\/\d{4}");
                    string date = match.Value;
                    if (!string.IsNullOrEmpty(date) && l.Contains(name))
                    {
                        var dateTime = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.CurrentCulture);
                        if (dateTime >= DateTime.Now.AddDays(-7))
                        {
                            logCount++;
                        }
                    }
                }
            MessageBox.Show($"User Logged in {logCount} times in the last 7 days.");
            }
        }
}
