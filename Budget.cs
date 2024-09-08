using System;
using System.Collections.Generic;

namespace App;

public class Budget
{
    public string Name;
    public DateTime DateStart;
    public DateTime DateEnd;
    public List<Transaction> Income;
    public List<Transaction> Expenses;
}