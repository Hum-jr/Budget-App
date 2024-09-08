using Godot;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using App;

public partial class Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Budget currentBudget = new Budget();
		currentBudget.Name = "Current Budget";
		currentBudget.Expenses = new List<Transaction>();
		currentBudget.Income = new List<Transaction>();
		
		currentBudget.Expenses.Add(new Transaction()
		{
				Name = "Test",
				Date = DateTime.Now(),
				Amount = 30,
				Type = "none"
		});
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
