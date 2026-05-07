using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    { 
        Session mySession = new Session(DateTime.Now, DateTime.Now, DateTime.Now, null);
        bool check = false;

        while (!check)
        {
            Console.Write("Enter name: ");
            string s = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(s))
            {
                if (!mySession.Attendees.Contains(s))
                {
                    mySession.AddAttendee(s);
                    check = true;
                    Console.WriteLine("Done");
                }
            }
            else
            {
                Console.WriteLine("Name is empty!");
            }
        }
    }
}
public class Session
{
    private DateTime _date;
    private DateTime _startTime;
    private DateTime _endTime;
    private object _course;
    private List<string> _attendees;
    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }
    public DateTime StartTime
    {
        get { return _startTime; }
        set { _startTime = value; }
    }
    public DateTime EndTime
    {
        get { return _endTime; }
        set { _endTime = value; }
    }
    public object Course
    {
        get { return _course; }
        set { _course = value; }
    }
    public List<string> Attendees
    {
        get { return _attendees; }
        set { _attendees = value; }
    }
    public Session(DateTime date, DateTime startTime, DateTime endTime, object course)
    {
        _date = date;
        _startTime = startTime;
        _endTime = endTime;
        _course = course;
        _attendees = new List<string>();
    }
    public void AddAttendee(string studentName)
    {
        if (string.IsNullOrWhiteSpace(studentName))
        {
            return;
        }
        if (!_attendees.Contains(studentName))
        {
            _attendees.Add(studentName);
        }
    }
}