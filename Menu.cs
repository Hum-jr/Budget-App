using Godot;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using App;

public partial class Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	
	Budget currentBudget;
	
	[Export]
	public PackedScene TransactionList;
	public override void _Ready()
	{
		currentBudget = new Budget()
		{
			Name = "Current Budget",
			Expenses = new List<Transaction>(),
			Income = new List<Transaction>(),
		};

		currentBudget.Expenses.Add(new Transaction()
		{
			Name = "Test",
			Date = DateTime.Now,
			Amount = 30,
			Type = "none"
		});
		
		currentBudget.Expenses.Add(new Transaction()
		{
			Name = "Test 1",
			Date = DateTime.Now,
			Amount = 30,
			Type = "none"
		});
		
		currentBudget.Expenses.Add(new Transaction()
		{
			Name = "Test 2",
			Date = DateTime.Now,
			Amount = 30,
			Type = "none"
		});


		VBoxContainer container = GetNode<VBoxContainer>("ScrollContainer/TransactionList");
		
		Node tableRow = TransactionList.Instantiate();
		tableRow.GetNode<RichTextLabel>("Name").Text = currentBudget.Expenses[0].Name;
		tableRow.GetNode<RichTextLabel>("Date").Text = currentBudget.Expenses[0].Date.ToString();
		tableRow.GetNode<RichTextLabel>("Amount").Text = currentBudget.Expenses[0].Amount.ToString();
		tableRow.GetNode<RichTextLabel>("Type").Text = currentBudget.Expenses[0].Type;
		container.AddChild(tableRow);
		
	}



	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print(currentBudget.Name);
		GD.Print(currentBudget.Expenses[0].Name);
	}
}
