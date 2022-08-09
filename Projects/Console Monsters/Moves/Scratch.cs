﻿namespace Console_Monsters.Moves;

public class Scratch : MoveBase
{
	public Scratch()
	{
		Name = "Scratch";
		BaseDamage = 40;
		FinalDamage = (((2 * AttackingMonster!.Level / 5 + 2) * BaseDamage * AttackingMonster.AttackStat / DefendingMonster!.DefenseStat) / 50 + 2) * BattleRandom.Next(85, 101) / 100;
		EnergyTaken = 10; // Temp
	}
}
